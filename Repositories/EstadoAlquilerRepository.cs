using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Repositories
{
    public class EstadoAlquilerRepository
    {
        public List<EstadoAlquiler> listarEstadosAlquiler()
        {
            List<EstadoAlquiler> estadoAlquileres;

            try
            {
                using (var context = new AppDbContext())
                {
                    estadoAlquileres = context.EstadoAlquiler.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los estados de alquiler: " + ex.Message);
            }
            return estadoAlquileres;
        }
    }
}
