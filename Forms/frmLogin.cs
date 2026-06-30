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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.IsNullOrEmpty() || txtPassword.Text.IsNullOrEmpty())
            {
                txtPassword.Clear();
                txtUsuario.Clear();
                MessageBox.Show("Por favor, complete los campos.","Sistema de Gestion Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var repo = new UsuariosRepository();
            var user = repo.Login(txtPassword.Text.Trim(), txtUsuario.Text.Trim());
            if (user == null) 
            {
                txtPassword.Clear();
                txtUsuario.Clear();
                MessageBox.Show("Usuario o Contrasena incorrecta.", "Sistema de Gestion Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SessionActual.UsuarioActual = user;
            frmMenuPrincipal frmPrinci = new frmMenuPrincipal();
            // 1. Decimos que la posición inicial será el centro del formulario Padre
            frmPrinci.StartPosition = FormStartPosition.CenterParent;

            // 2. Lo abrimos pasándole 'this' (el padre) como parámetro.
            //ShowDialog() hace que se abra por encima y bloquee el padre hasta que se cierre (Modal).
            frmPrinci.ShowDialog(this);
        }
    }
}
