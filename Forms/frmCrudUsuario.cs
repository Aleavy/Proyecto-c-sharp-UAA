using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.Helpers;
using AlquilerApp_Proyecto.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerApp_Proyecto.Forms
{
    public partial class frmCrudUsuario : Form
    {
        public frmCrudUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty())
            {
                txtPassword.Clear();
                txtUsuario.Clear();
                MessageBox.Show("Por favor, complete los campos.", "Sistema de Gestion Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var repo = new UsuariosRepository();
                repo.CrearUsuario(txtPassword.Text.Trim(), txtUsuario.Text.Trim(), cmbEmpleados.SelectedValue.ToString());
                MessageBox.Show("Usuario guardado exitosamente.",
                "Sistema de Gestion Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario.", ex);
            }




        }

        private void frmCrudUsuario_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            //using var context = new AppDbContext();
            //{
            //    var empleados = context.Empleados
            //        .Select(r => new
            //        {
            //            r.EmpleadoId,
            //            r.Nombre
            //        })
            //        .ToList();

            //    cmbEmpleados.DataSource = empleados;
            //    cmbEmpleados.DisplayMember = "Nombre";
            //    cmbEmpleados.ValueMember = "EmpleadoId";
            //    cmbEmpleados.SelectedIndex = -1;
            //}
        }
    }
}
