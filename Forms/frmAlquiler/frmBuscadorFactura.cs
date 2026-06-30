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
    public partial class frmBuscadorFactura : Form
    {
        public int codigoAlquiler { get; private set; }
        public int codigoCliente { get; private set; }
        private BindingSource bsFacturas = new BindingSource();
        List<FacturaBusquedaDTO> listaFacturas;
        public frmBuscadorFactura()
        {
            InitializeComponent();
            InicializarGrilla();
            CargarFiltrosFactura();
            CargarFacturas();
            
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string campoSeleccioando = "";

            if (cmbFiltroFactura.SelectedIndex == Convert.ToInt32(FiltroFactura.NroFactura))
            {
                campoSeleccioando = "NroFactura";
            }
            else if (cmbFiltroFactura.SelectedIndex == Convert.ToInt32(FiltroFactura.RUC_CI))
            {
                campoSeleccioando = "RUC_CI";
            }
            else if (cmbFiltroFactura.SelectedIndex == Convert.ToInt32(FiltroFactura.RazonSocial))
            {
                campoSeleccioando = "RazonSocial";
            }

           


            //Agrega el campo seleccionado y el valor del txtBuscador a la consulta
            var lista = FiltrarFactura(campoSeleccioando, txtBuscador.Text);



            // bsClientes.DataSource = lista; 
            //bsClientes.DataSource = ConvertirListToTable(lista);
            ActualizarrDataTable(lista);
            //OrdenarLista();
        }

        private void ActualizarrDataTable(List<FacturaBusquedaDTO> facturas)
        {
            bsFacturas.DataSource = facturas;
            dgvFacturas.Refresh();

        }
        private List<FacturaBusquedaDTO> FiltrarFactura(string filtro, string valor)
        {
            List<FacturaBusquedaDTO>? listaFiltrada = new List<FacturaBusquedaDTO>();

            var repo = new AlquilerDetalleRepository();

            if (!string.IsNullOrEmpty(valor))
            {
                switch (filtro)
                {
                    case "NroFactura":  
                        listaFiltrada = repo.ObtenerFacturaPorNroFactura(valor);
                        
                        break;
                    case "RUC_CI":

                        listaFiltrada = repo.ObtenerFacturaPorRUC_CI(valor);
                        break;
                    case "RazonSocial":

                        listaFiltrada = repo.ObtenerFacturaPorRazonSocial(valor);
                        break;
                }
                return listaFiltrada;
            }

            return listaFacturas;

        }
        private void CargarFiltrosFactura()
        {
            cmbFiltroFactura.DataSource = Enum.GetValues(typeof(FiltroFactura));
        }

        private void InicializarGrilla()
        {

            dgvFacturas.AutoGenerateColumns = false;
            dgvFacturas.Columns.Clear();
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona la fila completa al hacer clic
            dgvFacturas.ReadOnly = true; // El usuario no debe editar nada aquí

            // Creamos las columnas que queremos que el usuario vea para elegir el artículo
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Codigo",
                Name = "AlquilerId",
                DataPropertyName = "AlquilerId",
                Width = 70,
                Visible = false,
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nro Factura",
                Name = "NroFactura",
                DataPropertyName = "NroFactura",
                Width = 350
            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "RUC/CI",
                Name = "RUC_CI",
                DataPropertyName = "RUC_CI",
                Width = 350
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Codigo Cliente",
                Name = "ClienteId",
                DataPropertyName = "ClienteId",
                Width = 250,
                Visible = false
            });

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Razon Social",
                Name = "RazonSocial",
                DataPropertyName = "RazonSocial",
                Width = 250
            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha Emisión",
                Name = "FechaEmision",
                DataPropertyName = "FechaEmision",

            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                Name = "TotalFactura",
                DataPropertyName = "TotalFactura",
            });

        }


        private void CargarFacturas()
        {
            try
            {
                AlquilerDetalleRepository repo = new AlquilerDetalleRepository();
                listaFacturas = repo.ObtenerAlquileres();
                bsFacturas.DataSource = listaFacturas;
                dgvFacturas.DataSource = bsFacturas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message} ", "Buscador Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvFacturas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 1. Obtenemos la fila actual donde el usuario hizo doble clic
            codigoAlquiler = Convert.ToInt32(dgvFacturas.Rows[e.RowIndex].Cells["AlquilerId"].Value);
            codigoCliente = Convert.ToInt32(dgvFacturas.Rows[e.RowIndex].Cells["ClienteId"].Value);
            // 3. Decimos que la operación fue exitosa y cerramos la ventana emergente
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
