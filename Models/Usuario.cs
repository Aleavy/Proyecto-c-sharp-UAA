using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Models
{
    public class Usuario
    {
         public int UsuarioId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Estado {  get; set; }
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
    }
}
