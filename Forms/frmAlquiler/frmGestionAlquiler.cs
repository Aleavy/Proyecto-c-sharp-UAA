using AlquilerApp_Proyecto.Helpers;
using AlquilerApp_Proyecto.Models;
using AlquilerApp_Proyecto.Repositories;
using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerApp_Proyecto.Forms
{
    public partial class frmGestionAlquiler : Form
    {
        private BindingSource bsAlquiler = new BindingSource();
        private BindingList<AlquilerDetalleDTO> _detallesAlquiler = new BindingList<AlquilerDetalleDTO>();
        private int codigoAlquiler = 0;
        private Cliente clienteSeleccionado;
        
        public frmGestionAlquiler()
        {
            InitializeComponent();
            InicializarEstructuraTabla();
            CargarEstadosAlquiler();
            _detallesAlquiler.ListChanged += _detallesAlquiler_ListChanged;
            txtCliente.Enabled = false;
            //txtEmpleado.Enabled = false;
            ActivarCampos(false);
            ActivarBotones(true);
            InicializarClientePorDefecto();
            /*
             Consumidor Final
             1/RUC
             44444401-7
             000000
             Sin Dirección cambia nomas segun tu parecer los valores yo puse nomas por mostrar un ejemplo
             */
            DesactivarTotales(false);
            cmbEstado.SelectedIndex = -1;
            this.DialogResult = DialogResult.Cancel;
            txtEmpleado.Text = SessionActual.UsuarioActual.EmpleadoId.ToString();
            txtEmpleado.ReadOnly = true;
        }
        public void InicializarClientePorDefecto()
        {
            ClienteRepository clienteRepo = new ClienteRepository();
            clienteSeleccionado = clienteRepo.ObtenerClientePorId(1);
            txtCliente.Text = clienteSeleccionado.RazonSocial;
        }
        public void DesactivarTotales(bool activado)
        {
            txtTotal.Enabled = activado;
            txtSubtotal.Enabled = activado;
            txtIva.Enabled = activado;
        }
        private void ActivarCampos(bool activado)
        {
            dtpFechaDevolucion.Enabled = activado;
            dtpFechaEmision.Enabled = activado;
            dtpFechaEntrega.Enabled = activado;
            cmbEstado.Enabled = activado;
            btnAñadirCliente.Enabled = activado;
        }
        public void ActivarBotones(bool activado)
        {
            btnNuevo.Enabled = activado;
            btnConsultar.Enabled = activado;
            btnGuardar.Visible = !activado;
            btnCancelar.Visible = !activado;
        }

        private bool ValidarCampos()
        {
            bool esCampoVacio = false;

            if (cmbEstado.SelectedIndex == -1) esCampoVacio = true;
            if (string.IsNullOrEmpty(txtCliente.Text)) esCampoVacio = true;
            if (string.IsNullOrEmpty(txtEmpleado.Text)) esCampoVacio = true;

            
            return esCampoVacio;
        }

        private void LimpiarCampos()
        {
            dtpFechaEmision.Value = DateTime.Now;
            txtCliente.Clear();
            
            cmbEstado.SelectedIndex = -1;

            codigoAlquiler = 0;

        }

        private void InicializarEstructuraTabla()
        {
            // Evitamos que el DataGridView genere columnas automáticas por su cuenta
            dgvAlquilerDetalle.AutoGenerateColumns = false;


            //dgvAlquilerDetalle.Columns.Clear();

            // Conectamos la BindingList al BindingSource y este al DataGridView
            bsAlquiler.DataSource = _detallesAlquiler;
            dgvAlquilerDetalle.DataSource = bsAlquiler;

            // 2. Creamos y agregamos las columnas de texto normales mapeadas al DTO
            dgvAlquilerDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Artículo",
                Name = "ArticuloId",
                ReadOnly = true,
                DataPropertyName = nameof(AlquilerDetalleDTO.ArticuloId)
            });
            dgvAlquilerDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripcion",
                Name = "Descripcion",
                ReadOnly = true,
                DataPropertyName = nameof(AlquilerDetalleDTO.Descripcion)
            });
            dgvAlquilerDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cantidad",
                Name = "Cantidad",
                DataPropertyName = nameof(AlquilerDetalleDTO.Cantidad)
            });

            dgvAlquilerDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio Unitario",
                Name = "PrecioUnitario",
                ReadOnly = true,
                DataPropertyName = nameof(AlquilerDetalleDTO.PrecioUnitario),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvAlquilerDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Importe",
                Name = "Importe",
                DataPropertyName = nameof(AlquilerDetalleDTO.Importe),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                ReadOnly = true // El usuario no debe poder alterar el cálculo matemático
            });
            dgvAlquilerDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "IVA",
                Name = "PorcentajeIVA",
                DataPropertyName = nameof(AlquilerDetalleDTO.PorcentajeIVA),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                ReadOnly = true // El usuario no debe poder alterar el cálculo matemático
            });

            // Optimización: El combo se abre al primer clic y no al segundo
            dgvAlquilerDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
        }




        private void CargarEstadosAlquiler()
        {
            var repo = new EstadoAlquilerRepository();

            cmbEstado.ValueMember = "EstadoAlquilerId";
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.DataSource = repo.listarEstadosAlquiler();
            cmbEstado.SelectedValue = -1;
        }

        private void dgvAlquilerDetalle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Evitamos cabeceras
            if (e.RowIndex < 0) return;

            // 2. Al entrar aquí, ya estamos 100% seguros de que se hizo doble clic en el cuadro gris de la izquierda
            using (var frmBuscar = new frmBuscadorArticulos())
            {
                frmBuscar.StartPosition = FormStartPosition.CenterParent;
                if (frmBuscar.ShowDialog(this) == DialogResult.OK)
                {
                    // Seguridad: verificamos que la fila exista en la BindingList
                    if (e.RowIndex < _detallesAlquiler.Count)
                    {
                        // 3. Obtenemos el DTO de la fila actual
                        var detalleActual = _detallesAlquiler[e.RowIndex];

                        // 4. Inyectamos el ID que devolvió el buscador
                        detalleActual.ArticuloId = frmBuscar.ArticuloIdSeleccionado;
                        detalleActual.PrecioUnitario = frmBuscar.PrecioSeleccionado;
                        detalleActual.Descripcion = frmBuscar.DescripcionArticuloSeleccionado;



                        // 6. Forzamos a la grilla a redibujar toda la fila con los nuevos datos
                        dgvAlquilerDetalle.InvalidateRow(e.RowIndex);
                    }
                }
            }
        }
        private void _detallesAlquiler_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Este evento se dispara por muchas razones, pero solo nos interesa recalcular
            // si se modificó un elemento, se agregó uno nuevo o se eliminó.
            if (e.ListChangedType == ListChangedType.ItemChanged ||
                e.ListChangedType == ListChangedType.ItemAdded ||
                e.ListChangedType == ListChangedType.ItemDeleted)
            {
                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            decimal subTotalGeneral = _detallesAlquiler.Sum(d =>d.Importe);
            decimal totalIva = subTotalGeneral * 0.10m;
            decimal totalGeneral = subTotalGeneral + totalIva;

            txtSubtotal.Text = Math.Truncate(subTotalGeneral).ToString();
            txtIva.Text = Math.Truncate(totalIva).ToString();
            txtTotal.Text = Math.Truncate(totalGeneral).ToString();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ActivarCampos(true);
            ActivarBotones(false);
            dtpFechaEmision.Select();
            dgvAlquilerDetalle.DataSource = bsAlquiler;
            _detallesAlquiler.Clear(); 
            dgvAlquilerDetalle.ReadOnly = false;
            
        }
       

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<DetalleAlquiler> listaDetallesModelo = _detallesAlquiler
                       .Where(dto => dto.ArticuloId > 0 && dto.Cantidad > 0) //  FILTRO: Ignora filas vacías de la grilla
                       .Select(dto => new DetalleAlquiler
                       {

                           DetalleId = 0,

                           AlquilerId = 0, // Vinculación explícita
                           ArticuloId = dto.ArticuloId,
                           Cantidad = dto.Cantidad,
                           PrecioUnitario = dto.PrecioUnitario,
                           Subtotal = dto.Importe,
                           PorcentajeIva = dto.PorcentajeIVA
                       }).ToList();


                if (ValidarCampos())
                {
                    MessageBox.Show("Debe llenar todos los campos obligatorios", "Sistema de Gestion de Alquiler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (listaDetallesModelo.Count == 0)
                    {
                        MessageBox.Show("Debe cargar al menos un artículo con cantidad válida en el detalle.",
                                "Sistema de Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Alquiler alquiler = new Alquiler
                        {
                            AlquilerId = 0,
                            ClienteId = clienteSeleccionado.ClienteId,

                            FechaEmision = dtpFechaEmision.Value,
                            FechaDevolucion = dtpFechaDevolucion.Value,
                            FechaEntrega = dtpFechaEntrega.Value,
                            Detalles = listaDetallesModelo,
                            TotalFactura = Convert.ToDecimal(txtTotal.Text),
                            EstadoId = Convert.ToInt32(cmbEstado.SelectedValue),
                            EmpleadoId = Convert.ToInt32(txtEmpleado.Text),
                            RUC_CI = clienteSeleccionado.Documento

                        };
                        // GuardarCliente(cliente);
                        GuardarAlquiler(alquiler);

                        ActivarCampos(false);
                        ActivarBotones(true);
                        LimpiarCampos();
                        _detallesAlquiler.Clear();
                    }
                }
                     
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el alquiler: {ex.Message}", "Sistema de Gestion de Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarAlquiler(Alquiler alquiler)
        {

            codigoAlquiler = 0;

            var repo = new AlquilerDetalleRepository();
            repo.AgregarAlquiler(alquiler);

            MessageBox.Show("Alquiler Guardado Exitosamente", "Sistema de Gestion de Alquileres", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (frmBuscadorFactura frmBuscadorFactura = new frmBuscadorFactura())
            {
                frmBuscadorFactura.StartPosition = FormStartPosition.CenterParent;

                if (frmBuscadorFactura.ShowDialog(this) == DialogResult.OK)
                {
                    ClienteRepository clienteRepo = new ClienteRepository(); 
                    codigoAlquiler = frmBuscadorFactura.codigoAlquiler;
                    clienteSeleccionado = clienteRepo.ObtenerClientePorId(frmBuscadorFactura.codigoCliente);

                    AlquilerDetalleRepository alquilerRepo = new AlquilerDetalleRepository();
                    var alquiler = alquilerRepo.ObtenerAlquilerPorId(codigoAlquiler);
                    txtCliente.Text = clienteSeleccionado.RazonSocial;
                    txtEmpleado.Text = alquiler.EmpleadoId.ToString();
                    cmbEstado.SelectedValue = alquiler.EstadoId;
                    dtpFechaEmision.Value = alquiler.FechaEmision;
                    dtpFechaDevolucion.Value = alquiler.FechaDevolucion;
                    dtpFechaEntrega.Value = alquiler.FechaEntrega;

                    List<AlquilerDetalleDTO> detallesConsulta = alquiler.Detalles.Select(d => new AlquilerDetalleDTO
                    {
                      ArticuloId = d.ArticuloId,
                      Cantidad = d.Cantidad,
                      PrecioUnitario = d.PrecioUnitario,
                      Descripcion = d.Articulo.Descripcion,
                      PorcentajeIVA = d.PorcentajeIva
                    }).ToList();
                    
                    dgvAlquilerDetalle.DataSource = detallesConsulta;

                    decimal subTotalGeneral = detallesConsulta.Sum(d => d.Importe);
                    decimal totalIva = subTotalGeneral * 0.10m;
                    decimal totalGeneral = subTotalGeneral + totalIva;

                    txtSubtotal.Text = Math.Truncate(subTotalGeneral).ToString();
                    txtIva.Text = Math.Truncate(totalIva).ToString();
                    txtTotal.Text = Math.Truncate(totalGeneral).ToString();
                    
                   
                    dgvAlquilerDetalle.ReadOnly = true;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarCampos(false);
            ActivarBotones(true);
            LimpiarCampos();
            _detallesAlquiler.Clear();
        }

        private void lblAñadirCliente_Click(object sender, EventArgs e)
        {
            using (frmBuscadorCliente frmBuscadorCliente = new frmBuscadorCliente())
            {
                frmBuscadorCliente.StartPosition = FormStartPosition.CenterParent;
                // 2. Lo mostramos como cuadro de diálogo modal
                if (frmBuscadorCliente.ShowDialog(this) == DialogResult.OK)
                {
                    // 3. Si retornó OK, accedemos al cliente seleccionado directamente
                    clienteSeleccionado = frmBuscadorCliente.ClienteSeleccionado;
                    txtCliente.Text = clienteSeleccionado.RazonSocial;
                }
            }
        }

        
    }
}

