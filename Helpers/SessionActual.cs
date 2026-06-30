using AlquilerApp_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Helpers
{
    public static class SessionActual
    {
        public static Usuario UsuarioActual { get; set; }

        public static bool EstaLogueado
        {
            get { return UsuarioActual != null; }
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
