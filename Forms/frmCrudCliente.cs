using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.enums;
using AlquilerApp_Proyecto.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace AlquilerApp_Proyecto.Repositories
{
    public partial class frmCrudCliente : Form
    {
        //atributos para manejar la lista de clientes y su visualización
        private BindingSource bsClientes = new BindingSource();
        List<Cliente> listaClientes;
        DataTable tablaClientes;
        bool estadoGuardar = true; // true = modo agregar, false = modo modificar
        int codigoCliente = 0;


        public frmCrudCliente()
        {
            InitializeComponent();
            InicializarEstructuraTabla();
            CargarDatos();
            CargarTiposDocumentos();
            CargarFiltros();
            cmbFiltroCliente.SelectedIndex = 0;
            ActivarCampos(false);
            ActivarBotones(true);
            
            cmbTipoDocumento.SelectedIndex = -1;
            this.DialogResult = DialogResult.Cancel;

        }
        private void CargarFiltros()
        {

            cmbFiltroCliente.DataSource = Enum.GetValues(typeof(FiltroCliente));

        }
        private void CargarTiposDocumentos()
        {
            var repo = new TipoDocumentoRepository();

            cmbTipoDocumento.ValueMember = "TipoDocumentoId";
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.DataSource = repo.listarTiposDocumentos();
        }
        private void FormatearDgv()
        {
            dgvClientes.Columns[0].Width = 45;
            dgvClientes.Columns[2].Width = 95;
            dgvClientes.Columns[3].Width = 200;
            dgvClientes.Columns[4].Width = 120;
            dgvClientes.Columns[5].Width = 160;
        }
        private void InicializarEstructuraTabla()
        {
            tablaClientes = new DataTable();
            tablaClientes.Columns.Add("Id", typeof(int));
            tablaClientes.Columns.Add("Documento", typeof(string));
            tablaClientes.Columns.Add("Tipo de Documento", typeof(string));
            tablaClientes.Columns.Add("Razón Social", typeof(string));
            tablaClientes.Columns.Add("Télefono", typeof(string));
            tablaClientes.Columns.Add("Dirección de Entrega", typeof(string));
            // Asignación inicial única de conexiones
            bsClientes.DataSource = tablaClientes;
            dgvClientes.DataSource = bsClientes;
        }

        private void CargarDatos()
        {
            var repo = new ClienteRepository();
            //Obtiene la lista de clientes desde el repositorio
            listaClientes = repo.ObtenerCliente();

            // Llenamos el DataTable existente sin destruir sus columnas
            ActualizarrDataTable(listaClientes);
        }


        private void ActualizarrDataTable(List<Cliente> clientes)
        {
            tablaClientes.Clear(); // Borra los datos viejos, mantiene los encabezados
            foreach (Cliente c in clientes)
            {
                tablaClientes.Rows.Add(c.ClienteId, c.Documento, c.TipoDocumento.Nombre, c.RazonSocial, c.Telefono, c.DireccionEntrega);
            }
            bsClientes.ResetBindings(false); // Refresca la grilla de inmediato
        }



        private void ActivarCampos(bool activado)
        {
            txtDocumento.Enabled = activado;
            cmbTipoDocumento.Enabled = activado;
            txtRazonSocial.Enabled = activado;
            txtTelefono.Enabled = activado;
            txtDireccion.Enabled = activado;
            txtBuscador.Enabled = !activado;
            cmbFiltroCliente.Enabled = !activado;
        }

        private void ActivarBotones(bool activado)
        {
            btnNuevo.Enabled = activado;
            btnEliminar.Enabled = activado;
            btnActualizar.Enabled = activado;

            btnGuardar.Visible = !activado;
            btnCancelar.Visible = !activado;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            CargarDatos();
           // OrdenarLista();
        }

        private bool ValidarCampos()
        {
            bool esCampoVacio = false;

            if (string.IsNullOrEmpty(txtDocumento.Text)) esCampoVacio = true;
            if (string.IsNullOrEmpty(txtRazonSocial.Text)) esCampoVacio = true;
            if (cmbTipoDocumento.SelectedIndex == -1) esCampoVacio = true;
            if (string.IsNullOrEmpty(txtTelefono.Text)) esCampoVacio = true;
            if (string.IsNullOrEmpty(txtDireccion.Text)) esCampoVacio = true;

            return esCampoVacio;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                Cliente cliente = new Cliente
                {
                    ClienteId = codigoCliente,
                    RazonSocial = this.txtRazonSocial.Text,
                    TipoDocumentoId = Convert.ToInt32(cmbTipoDocumento.SelectedValue),
                    Documento = this.txtDocumento.Text,
                    Telefono = this.txtTelefono.Text,
                    DireccionEntrega = this.txtDireccion.Text
                };

                if (estadoGuardar)
                {
                    if (ValidarCampos())
                    {
                        MessageBox.Show("Debe llenar todos los campos obligatorios", "Sistema de Gestion de Cliente",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        GuardarCliente(cliente);
                        ActivarCampos(false);
                        ActivarBotones(true);
                        LimpiarCampos();
                        dgvClientes.ClearSelection();
                    }
                }
                else
                {
                    if (!ValidarCampos())
                    {
                        ActualizarCliente(cliente);
                        ActivarCampos(false);
                        ActivarBotones(true);
                        LimpiarCampos();
                        dgvClientes.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Debe llenar todos los campos obligatorios", "Sistema de Gestion de Cliente",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Sistema de Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarCampos(false);
            ActivarBotones(true);
            LimpiarCampos();
            dgvClientes.CurrentCell = null;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (codigoCliente == 0)
            {
                MessageBox.Show("Seleccione primero un registro/cliente.", "Sistema de Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estadoGuardar = false;
                ActivarBotones(false);
                ActivarCampos(true);
                txtDocumento.Select();
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            estadoGuardar = true;
            ActivarCampos(true);
            ActivarBotones(false);
            txtDocumento.Select();
        }





        private void ActualizarCliente(Cliente cliente)
        {

            var repoCliente = new ClienteRepository();

            repoCliente.ModificarCliente(cliente);
            CargarDatos();
            MessageBox.Show("Cliente Modificado Exitosamente", "Sistema de Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void GuardarCliente(Cliente cliente)
        {
            codigoCliente = 0;

            var repo = new ClienteRepository();
            repo.AgregarCliente(cliente);
            CargarDatos();
            MessageBox.Show("Cliente Guardado Exitosamente", "Sistema de Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void LimpiarCampos()
        {
            txtDocumento.Clear();
            txtRazonSocial.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            codigoCliente = 0;
            cmbTipoDocumento.SelectedIndex = -1;
        }







        /*
        private void OrdenarLista()
        {
            if (bsClientes.DataSource == null) return;

            if (ordenPrioridad.Count > 0)
            {

                if (cmsOrdenarDesc.Checked)
                {
                    var clausulas = ordenPrioridad.Select(campo => campo.Replace(" ASC", " DESC"));
                    bsClientes.Sort = string.Join(", ", clausulas);
                }
                else
                {
                    bsClientes.Sort = string.Join(", ", ordenPrioridad);
                }

            }
            else
            {

                if (cmsOrdenarDesc.Checked)
                {
                    bsClientes.Sort = "Id DESC";
                }
                else
                {
                    bsClientes.Sort = "Id ASC";
                }

            }
        }
        */
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string campoSeleccioando = "";

            if (cmbFiltroCliente.SelectedIndex == Convert.ToInt32(FiltroCliente.Id))
            {
                campoSeleccioando = "Id";
            }
            else if (cmbFiltroCliente.SelectedIndex == Convert.ToInt32(FiltroCliente.RazonSocial))
            {
                campoSeleccioando = "RazonSocial";
            }
            else if (cmbFiltroCliente.SelectedIndex == Convert.ToInt32(FiltroCliente.CI_RUC))
            {
                campoSeleccioando = "CI/RUC";
            }


            var repo = new ClienteRepository();

            //Agrega el campo seleccionado y el valor del txtBuscador a la consulta
            var lista = FiltrarCliente(campoSeleccioando, txtBuscador.Text);



            // bsClientes.DataSource = lista; 
            //bsClientes.DataSource = ConvertirListToTable(lista);
            ActualizarrDataTable(lista);
            //OrdenarLista();
        }

        private List<Cliente> FiltrarCliente(string filtro, string valor)
        {
            List<Cliente> listaFiltrada = new List<Cliente>();
            var daoCliente = new ClienteRepository();

            if (!string.IsNullOrEmpty(valor))
            {
                switch (filtro)
                {
                    case "Id":

                        if (int.TryParse(valor, out int id))
                        {

                            var clienteEncontrado = daoCliente.ObtenerClientePorId(id);

                            if (clienteEncontrado != null)
                            {
                                listaFiltrada = new List<Cliente> { clienteEncontrado };
                            }
                        }
                        break;
                    case "RazonSocial":
                        listaFiltrada = daoCliente.ObtenerClientePorRazonSocial(valor);
                        break;
                    case "CI/RUC":
                        listaFiltrada = daoCliente.ObtenerClientePorDocumento(valor);
                        break;
                }
                return listaFiltrada;
            }

            return listaClientes;

        }
        

        private void dgvClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvClientes.ClearSelection();
            FormatearDgv();
        }



        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var registroCliente = dgvClientes.CurrentRow;

            codigoCliente = Convert.ToInt32(registroCliente.Cells["Id"].Value);


            this.cmbTipoDocumento.Text = registroCliente.Cells["Tipo de Documento"].Value.ToString();
            this.txtDocumento.Text = registroCliente.Cells["Documento"].Value.ToString();
            this.txtRazonSocial.Text = registroCliente.Cells["Razón Social"].Value.ToString();

            this.txtTelefono.Text = registroCliente.Cells["Télefono"].Value.ToString();
            this.txtDireccion.Text = registroCliente.Cells["Dirección de Entrega"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (codigoCliente == 0)
            {
                MessageBox.Show("Seleccione primero un registro/cliente.", "Sistema de Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Esta seguro de eliminar este cliente?", "Sistema de Gestion de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    EliminarCliente();
                    MessageBox.Show("Cliente Eliminado Exitosamente", "Sistema de Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    LimpiarCampos();
                }
            }
        }

        private void EliminarCliente()
        {
            var registroCliente = dgvClientes.CurrentRow;

            codigoCliente = Convert.ToInt32(registroCliente.Cells["Id"].Value);

            var repoCliente = new ClienteRepository();

            repoCliente.EliminarCliente(codigoCliente);
            codigoCliente = 0;
        }

        
    }

}
