using AlquilerApp_Proyecto.enums;
using AlquilerApp_Proyecto.Models;
using AlquilerApp_Proyecto.Repositories;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmBuscadorArticulos : Form
    {
        private BindingSource bsArticulos = new BindingSource();
        List<Articulo> listaArticulos;
        public int ArticuloIdSeleccionado { get; private set; }
        public string DescripcionArticuloSeleccionado { get; private set; }
        public decimal PrecioSeleccionado { get; private set; }

        public frmBuscadorArticulos()
        {
            InitializeComponent();
            CargarListaArticulos();
            InicializarGridBuscador();
            CargarFiltrosArticulo();
        }

        private void CargarFiltrosArticulo()
        {
            cmbFiltroArticulo.DataSource = Enum.GetValues(typeof(FiltroArticulo));
        }


        private void CargarListaArticulos()
        {
            try
            {
                // 1. Instanciamos el repositorio real de artículos
                var repo = new ArticuloRepository();

                // 2. Traemos la lista de artículos directamente desde la base de datos
                // Nota: Asegúrate de que tu repositorio tenga un método que devuelva la List<Articulo>
                listaArticulos = repo.ObtenerArticulo();

                // 3. Enlazamos los datos a la grilla mediante el BindingSource
                bsArticulos.DataSource = listaArticulos;
                dgvArticulos.DataSource = bsArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los artículos: {ex.Message}", "Buscador Articulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InicializarGridBuscador()
        {
            // Evitamos que genere columnas raras y limpiamos las existentes
            dgvArticulos.AutoGenerateColumns = false;
            dgvArticulos.Columns.Clear();
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selecciona la fila completa al hacer clic
            dgvArticulos.ReadOnly = true; // El usuario no debe editar nada aquí

            // Creamos las columnas que queremos que el usuario vea para elegir el artículo
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                Name = "ArticuloId",
                DataPropertyName = "ArticuloId",
                Width = 70
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripcion",
                Name = "Descripcion",
                DataPropertyName = "Descripcion",
                Width = 350
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoria",
                Name = "CategoriaNombre",
                DataPropertyName = "CategoriaNombre",
                Width = 350
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock",
                Name = "StockDisponible",
                DataPropertyName = "StockDisponible",
                Width = 250
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                Name = "PrecioListaAlquiler",
                DataPropertyName = "PrecioListaAlquiler",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } // Formato sin decimales para Guaraníes
            });
        }



        private void dgvArticulos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 1. Obtenemos la fila actual donde el usuario hizo doble clic
            var fila = dgvArticulos.Rows[e.RowIndex];

            // 2. Guardamos los datos en nuestras propiedades públicas 
            // (Asegúrate de que los nombres de celdas coincidan con tu grilla de artículos)
            ArticuloIdSeleccionado = Convert.ToInt32(fila.Cells["ArticuloId"].Value);
            DescripcionArticuloSeleccionado = fila.Cells["Descripcion"].Value.ToString();
            PrecioSeleccionado = Convert.ToDecimal(fila.Cells["PrecioListaAlquiler"].Value);

            // 3. Decimos que la operación fue exitosa y cerramos la ventana emergente
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string campoSeleccioando = "";

            if (cmbFiltroArticulo.SelectedIndex == Convert.ToInt32(FiltroArticulo.Id))
            {
                campoSeleccioando = "Id";
            }
            else if (cmbFiltroArticulo.SelectedIndex == Convert.ToInt32(FiltroArticulo.Descripcion))
            {
                campoSeleccioando = "Descripcion";
            }
            else if (cmbFiltroArticulo.SelectedIndex == Convert.ToInt32(FiltroArticulo.Categoria))
            {
                campoSeleccioando = "Categoria";
            }


            //Agrega el campo seleccionado y el valor del txtBuscador a la consulta
            var lista = FiltrarArticulo(campoSeleccioando, txtBuscador.Text);



            // bsClientes.DataSource = lista; 
            //bsClientes.DataSource = ConvertirListToTable(lista);
            ActualizarrDataTable(lista);
            //OrdenarLista();
        }

        private void ActualizarrDataTable(List<Articulo> articulos)
        {
            bsArticulos.DataSource = articulos;
            dgvArticulos.Refresh();

        }
        private List<Articulo>? FiltrarArticulo(string filtro, string valor)
        {
            List<Articulo>? listaFiltrada = new List<Articulo>();
            var repo = new ArticuloRepository();

            if (!string.IsNullOrEmpty(valor))
            {
                switch (filtro)
                {
                    case "Id":

                        if (int.TryParse(valor, out int id))
                        {

                            var articuloEncontrado = repo.ObtenerArticuloPorId(id);

                            if (articuloEncontrado != null)
                            {
                                listaFiltrada = new List<Articulo> { articuloEncontrado};
                            }
                        }
                        break;
                    case "Descripcion":
                        
                        listaFiltrada = new List<Articulo>(repo.ObtenerArticuloPorDescripcion(valor));
                        break;
                    case "Categoria":
                       
                       listaFiltrada = new List<Articulo>(repo.ObtenerArticuloPorCategoria(valor));
                        break;
                }
                return listaFiltrada;
            }

            return listaArticulos;

        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1. Verificamos que estemos en la columna correcta y que la fila tenga datos reales
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "CategoriaNombre" && e.RowIndex >= 0)
            {
                // 2. Obtenemos el objeto 'Articulo' completo asignado a esa fila
                var articulo = dgvArticulos.Rows[e.RowIndex].DataBoundItem as Articulo;

                // 3. Si el artículo no es nulo y tiene una categoría cargada, mostramos el nombre
                if (articulo != null && articulo.Categoria != null)
                {
                    e.Value = articulo.Categoria.Nombre; //  como se llame la propiedad string en tu modelo Categoria (ej: Descripcion, NombreCategoria)
                }/*
                else
                {
                    e.Value = "Sin Categoría"; // Mensaje por defecto si viene nulo
                }*/
            }
        }
    }
}