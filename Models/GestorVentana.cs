using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Models
{
    public class GestorVentana

    {
            public static void AbrirFormularioModal(Form menu, Form submenu)
            {
                //se minimiza el formulario de menu para que no se vea mientras se muestra el submenu
                menu.WindowState = FormWindowState.Minimized;
                
                //se muestra el formulario de submenu 
                submenu.ShowDialog();

                //se restaura el formulario de menu a su estado original una vez que se cierre el submenu
                menu.WindowState = FormWindowState.Normal;
            }
            
    }
}
