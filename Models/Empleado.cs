using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string CI { get; set; }
        public string telefono { get; set; }

        public Empleado() {}


        public Empleado(int id, string nombre, string CI, string telefono)
        {
            this.EmpleadoId = id;
            this.Nombre = nombre;
            this.CI = CI;
            this.telefono = telefono;
        }   
    }
}
