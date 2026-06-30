using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.Forms;
using AlquilerApp_Proyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Repositories
{
    public class ArticuloRepository
    {

        

        //Alta
        public void AgregarArticulo(Articulo articulo)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Articulo.Add(articulo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar un articulo: {ex.Message}");
            }
        }

        //Consulta

        public List<Articulo> ObtenerArticulo()
        {
            List<Articulo> listaArticulos;

               
            try
            {
                using (var context = new AppDbContext())
                {
                    listaArticulos = context.Articulo.Include(c => c.Categoria).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los artiulos: " + ex.Message);
            }

            return listaArticulos;
        }
        public Articulo ObtenerArticuloPorId(int id)
        {
            Articulo articulo;
            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    articulo = context.Articulo.Include(c => c.Categoria).FirstOrDefault(a => a.ArticuloId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el articulo: " + ex.Message);
            }

            return articulo;
        }

        public List<Articulo> ObtenerArticuloPorCategoria(string valor)
        {
            List<Articulo> articulos;
            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    articulos = new List<Articulo>(context.Articulo.Include(c => c.Categoria).Where(c => c.Categoria.Nombre.ToLower().Contains(valor.ToLower())).ToList());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el articulo: " + ex.Message);
            }

            return articulos;
        }

        public List<Articulo> ObtenerArticuloPorDescripcion(string valor)
        {
            List<Articulo> articulos;
            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    articulos = new List<Articulo>(context.Articulo.Include(c => c.Categoria)
                                                                    .Where(a => a.Descripcion.ToLower().Contains(valor.ToLower()))
                                                                    .ToList());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el articulo: " + ex.Message);
            }

            return articulos;
        }


        //Modificar 

        public void ModificarCliente(Articulo articulo)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        context.Articulo.Update(articulo);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al modificar el articulo: {ex.Message}");
                }
            }

            public void EliminarCliente(int id)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var articulo = new Articulo{ ArticuloId= id };//Objeto "ficticio", solo tiene el ID
                        context.Articulo.Attach(articulo); // EF ahora lo rastrea en estado 'Unchanged'
                        context.Articulo.Remove(articulo);// EF lo marca como 'Deleted'
                        context.SaveChanges();// EF genera un DELETE basado en el ID sin necesidad de cargar toda la entidad desde la base de datos
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al eliminar el articulo: {ex.Message}");
                }
            }
        }
}

