using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Repositories
{
    public class AlquilerDetalleRepository
    {


        public void AgregarAlquiler(Alquiler alquiler)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Alquiler.Add(alquiler);
                    context.SaveChanges(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar un alquiler: {ex.Message}",ex);
            }
        }

        public Alquiler ObtenerAlquilerPorId(int id)
        {
            Alquiler alquiler;

            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    alquiler = context.Alquiler.Include(p => p.Detalles).ThenInclude(a => a.Articulo).FirstOrDefault(a => a.AlquilerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el alquiler: " + ex.Message);
            }

            return alquiler;
        }

        public List<FacturaBusquedaDTO> ObtenerAlquileres()
        {
            List<FacturaBusquedaDTO> alquileres;
            try
            {
                using (var context = new AppDbContext())
                {
                    alquileres = context.Alquiler
                        .Select(d => new FacturaBusquedaDTO
                        {
                            AlquilerId = d.AlquilerId,
                            NroFactura = d.NroFactura,
                            RUC_CI = d.RUC_CI,
                            ClienteId = d.Cliente.ClienteId,
                            RazonSocial = d.Cliente.RazonSocial,
                            FechaEmision = d.FechaEmision,
                            TotalFactura = d.TotalFactura
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los alquileres: " + ex.Message);
            }
            return alquileres;
        }

        public List<FacturaBusquedaDTO> ObtenerFacturaPorNroFactura(string nroFactura)
        {
            List<FacturaBusquedaDTO> alquileres;
            try
            {
                using (var context = new AppDbContext())
                {
                   
                    return context.Alquiler
                        // Filtramos primero: Validamos que Cliente no sea null y que contenga el texto
                        .Where(d => d.NroFactura.Contains(nroFactura))
                        .Select(d => new FacturaBusquedaDTO
                        {
                            AlquilerId = d.AlquilerId,
                            NroFactura = d.NroFactura,
                            RUC_CI = d.RUC_CI,
                            ClienteId = d.Cliente.ClienteId,
                            RazonSocial = d.Cliente.RazonSocial,
                            FechaEmision = d.FechaEmision,
                            TotalFactura = d.TotalFactura
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los alquileres: " + ex.Message);
            }
            return alquileres;
        }

        public List<FacturaBusquedaDTO> ObtenerFacturaPorRUC_CI(string ruc_ci)
        {
            List<FacturaBusquedaDTO> alquileres = new List<FacturaBusquedaDTO>();
            try
            {
                using (var context = new AppDbContext())
                {
                  
                    return context.Alquiler
                        // Filtramos primero: Validamos que Cliente no sea null y que contenga el texto
                        .Where(d => d.RUC_CI.Contains(ruc_ci))
                        .Select(d => new FacturaBusquedaDTO
                        {
                            AlquilerId = d.AlquilerId,
                            NroFactura = d.NroFactura,
                            RUC_CI = d.RUC_CI,
                            ClienteId = d.Cliente.ClienteId,
                            RazonSocial = d.Cliente.RazonSocial,
                            FechaEmision = d.FechaEmision,
                            TotalFactura = d.TotalFactura
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los alquileres: " + ex.Message);
            }
            return alquileres;

        }

        public List<FacturaBusquedaDTO>  ObtenerFacturaPorRazonSocial(string razonSocial)
        {
            List<FacturaBusquedaDTO> alquileres = new List<FacturaBusquedaDTO>();
            try
            {
                using (var context = new AppDbContext())
                {

                  alquileres = context.Alquiler
                        // Filtramos primero: Validamos que Cliente no sea null y que contenga el texto
                        .Where(d => d.Cliente.RazonSocial.ToLower().Contains(razonSocial.ToLower()))
                        .Select(d => new FacturaBusquedaDTO
                        {
                            AlquilerId = d.AlquilerId,
                            NroFactura = d.NroFactura,
                            RUC_CI = d.RUC_CI,
                            ClienteId = d.Cliente.ClienteId,
                            RazonSocial = d.Cliente.RazonSocial,
                            FechaEmision = d.FechaEmision,
                            TotalFactura = d.TotalFactura
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los alquileres: " + ex.Message);
            }
            return alquileres;

        }

        //Modificar 

        public void ModificarAlquiler(Alquiler Alquiler)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Alquiler.Update(Alquiler);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el alquiler: {ex.Message}");
            }
        }

        public void EliminarAlquiler(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var alquiler = new Alquiler{ AlquilerId = id };//Objeto "ficticio", solo tiene el ID
                    context.Alquiler.Attach(alquiler); // EF ahora lo rastrea en estado 'Unchanged'
                    context.Alquiler.Remove(alquiler);// EF lo marca como 'Deleted'
                    context.SaveChanges();// EF genera un DELETE basado en el ID sin necesidad de cargar toda la entidad desde la base de datos
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el alquiler: {ex.Message}");
            }
        }

        

    }
}
