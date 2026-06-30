using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AlquilerApp_Proyecto.Repositories
{
   
    public class ClienteRepository
    {

        //Alta
        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges(); // hace automaticamente un commit a la base de datos, si no se llama a este método, los cambios no se guardarán en la base de datos
                }
            }
            catch (Exception ex)
            {
               throw new Exception ($"Error al guardar un cliente: {ex.Message}");
            }
        }

        //Consulta

        public List<Cliente> ObtenerCliente()
        {
            List<Cliente> listaClientes;

            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    listaClientes = context.Cliente.Include(c => c.TipoDocumento).OrderBy(c => c.ClienteId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message);
            }

            return listaClientes;
        }
        public Cliente ObtenerClientePorId(int id)
        {
            Cliente cliente;

            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    cliente = context.Cliente.Include(c => c.TipoDocumento).FirstOrDefault(c => c.ClienteId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message);
            }

            return cliente;
        }

        public List<Cliente> ObtenerClientePorRazonSocial(string razonSocial)
        {
            List<Cliente> clientes;

            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    clientes = new List<Cliente>(context.Cliente.Include(c => c.TipoDocumento).Where(c => c.RazonSocial.ToLower().Contains(razonSocial.ToLower())).ToList()); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message);
            }

            return clientes;
        }

        public List<Cliente> ObtenerClientePorDocumento(string documento)
        {
            List<Cliente> clientes;

            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    clientes = new List<Cliente>(context.Cliente.Include(c => c.TipoDocumento).Where(c => c.Documento.Contains(documento)).ToList());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes: " + ex.Message);
            }

            return clientes;
        }

        //Modificar 

        public void ModificarCliente(Cliente cliente)
        {
            try
            {
                using (var context = new AppDbContext())
                {     
                    context.Cliente.Update(cliente);
                    context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error al modificar el cliente: {ex.Message}");
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var cliente = new Cliente { ClienteId = id };//Objeto "ficticio", solo tiene el ID
                    context.Cliente.Attach(cliente); // EF ahora lo rastrea en estado 'Unchanged'
                    context.Cliente.Remove(cliente);// EF lo marca como 'Deleted'
                    context.SaveChanges();// EF genera un DELETE basado en el ID sin necesidad de cargar toda la entidad desde la base de datos
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el cliente: {ex.Message}");
            }
        }

    }
}
