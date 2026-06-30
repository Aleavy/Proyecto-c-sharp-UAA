using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.enums;
using AlquilerApp_Proyecto.Forms;
using AlquilerApp_Proyecto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Repositories
{
    public class UsuariosRepository
    {
        public Usuario Login (string password,  string username)
        {
			try
			{

                username = username.Trim();
                using var context = new AppDbContext();
                var usuario = context.Usuarios.Where(u=> u.Username ==  username).FirstOrDefault();
                if (usuario != null && CheckPassword(password, usuario.Password))
                {
                    return usuario;
                }
                return null;
			}
			catch (Exception ex)
			{
                throw new Exception("Error al logear: " + ex.Message);

			}
        }

        public static string Encrypt(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool CheckPassword(string passwordIngresada, string passwordGuardada)
        {
            return BCrypt.Net.BCrypt.Verify(passwordIngresada, passwordGuardada);
        }

        public void CrearUsuario(string password, string username, string idEmpleado)
        {
            using var context = new AppDbContext();
            var user = new Usuario
            {
                Password = Encrypt(password),
                Username = username,
                FechaAlta = DateTime.Now,
                Estado = nameof(UsuarioEstado.HABILITADO),
                EmpleadoId = int.Parse(idEmpleado)
            };
            context.Usuarios.Add(user);
        }


    }
}
