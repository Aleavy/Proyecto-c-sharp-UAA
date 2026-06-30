using AlquilerApp_Proyecto.enums;
using AlquilerApp_Proyecto.Models;
using AlquilerApp_Proyecto.Repositories;
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
    public partial class frmBuscadorCliente : Form
    {
        public static Cliente ClienteSeleccionado { get; private set; }
        private BindingSource bsClientes = new BindingSource();
        List<Cliente> listaClientes;
        DataTable tablaClientes;
        public frmBuscadorCliente()
        {
            InitializeComponent();
            InicializarEstructuraTabla();
            CargarDatos();
            CargarFiltros();
            ClienteSeleccionado = new Cliente();
        }

        private void CargarFiltros()
        {

            cmbFiltro.DataSource = Enum.GetValues(typeof(FiltroCliente));

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

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string campoSeleccioando = "";

            if (cmbFiltro.SelectedIndex == Convert.ToInt32(FiltroCliente.Id))
            {
                campoSeleccioando = "Id";
            }
            else if (cmbFiltro.SelectedIndex == Convert.ToInt32(FiltroCliente.RazonSocial))
            {
                campoSeleccioando = "RazonSocial";
            }
            else if (cmbFiltro.SelectedIndex == Convert.ToInt32(FiltroCliente.CI_RUC))
            {
                campoSeleccioando = "CI/RUC";
            }


            

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

            int codigoCliente = Convert.ToInt32(registroCliente.Cells["Id"].Value);
            var repo = new ClienteRepository();

            try
            {
                ClienteSeleccionado = repo.ObtenerClientePorId(codigoCliente);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}", "Sistema de Gestion de Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
