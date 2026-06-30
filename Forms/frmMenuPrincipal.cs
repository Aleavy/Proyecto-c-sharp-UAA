using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerApp_Proyecto.Forms.frmAlquiler;
using AlquilerApp_Proyecto.Models;
using AlquilerApp_Proyecto.Repositories;

namespace AlquilerApp_Proyecto.Forms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void btnMenuCliente_Click(object sender, EventArgs e)
        {

            frmCrudCliente frmCliente = new frmCrudCliente();
            // 1. Decimos que la posición inicial será el centro del formulario Padre
            frmCliente.StartPosition = FormStartPosition.CenterParent;

            // 2. Lo abrimos pasándole 'this' (el padre) como parámetro.
            //ShowDialog() hace que se abra por encima y bloquee el padre hasta que se cierre (Modal).
            frmCliente.ShowDialog(this);

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Desea salir de la app?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMenuAlquilerDetalle_Click(object sender, EventArgs e)
        {
            frmGestionAlquiler frmAlquiler = new frmGestionAlquiler();
            // 1. Decimos que la posición inicial será el centro del formulario Padre
            frmAlquiler.StartPosition = FormStartPosition.CenterParent;

            // 2. Lo abrimos pasándole 'this' (el padre) como parámetro.
            //ShowDialog() hace que se abra por encima y bloquee el padre hasta que se cierre (Modal).
            frmAlquiler.ShowDialog(this);
        }

        private void btnMenuEmpleado_Click(object sender, EventArgs e)
        {
            frmCrudEmpleado frmEmpleado = new frmCrudEmpleado();
            // 1. Decimos que la posición inicial será el centro del formulario Padre
            frmEmpleado.StartPosition = FormStartPosition.CenterParent;

            // 2. Lo abrimos pasándole 'this' (el padre) como parámetro.
            //ShowDialog() hace que se abra por encima y bloquee el padre hasta que se cierre (Modal).
            frmEmpleado.ShowDialog(this);
        }

        private void btbMenuEstadoAlquiler_Click(object sender, EventArgs e)
        {
            frmCrudEstadoAlquiler frmEstadoAlquiler = new frmCrudEstadoAlquiler();
            // 1. Decimos que la posición inicial será el centro del formulario Padre
            frmEstadoAlquiler.StartPosition = FormStartPosition.CenterParent;

            // 2. Lo abrimos pasándole 'this' (el padre) como parámetro.
            //ShowDialog() hace que se abra por encima y bloquee el padre hasta que se cierre (Modal).
            frmEstadoAlquiler.ShowDialog(this);
        }

        private void btnMenuTipoDocumento_Click(object sender, EventArgs e)
        {
            frmCrudTipoDocumento frmTipoDocumento = new frmCrudTipoDocumento();

            frmTipoDocumento.StartPosition = FormStartPosition.CenterParent;


            frmTipoDocumento.ShowDialog(this);
        }

        private void btnMenuCategoria_Click(object sender, EventArgs e)
        {
            frmCrudCategoria frmCategoria = new frmCrudCategoria();

            frmCategoria.StartPosition = FormStartPosition.CenterParent;


            frmCategoria.ShowDialog(this);
        }

        private void btnMenuArticulo_Click(object sender, EventArgs e)
        {
            frmCrudArticulo frmArticulo = new frmCrudArticulo();

            frmArticulo.StartPosition = FormStartPosition.CenterParent;


            frmArticulo.ShowDialog(this);
        }

        private void btnUsuarioCrud_Click(object sender, EventArgs e)
        {
            frmCrudUsuario frmUsuario = new frmCrudUsuario();

            frmUsuario.StartPosition = FormStartPosition.CenterParent;


            frmUsuario.ShowDialog(this);
        }
    }
}
