using AlquilerApp_Proyecto.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Repositories
{
    public class AlquilerRepository
    {
        public static void CargarAlquileresConDetalle(DataGridView dgv)
        {
            using (var db = new AppDbContext())
            {
                var datos = db.DetalleAlquiler
                    .Include(d => d.Alquiler)
                        .ThenInclude(a => a.Cliente)
                    .Include(d => d.Alquiler)
                        .ThenInclude(a => a.Empleado)
                    .Include(d => d.Alquiler)
                        .ThenInclude(a => a.Estado)
                    .Include(d => d.Articulo)
                    .Select(d => new
                    {
                        Factura = d.Alquiler.NroFactura,
                        Cliente = d.Alquiler.Cliente.ClienteId,
                        RUC_CI = d.Alquiler.RUC_CI,
                        Empleado = d.Alquiler.Empleado.Nombre,
                        Estado = d.Alquiler.Estado.Nombre,

                        FechaEmision = d.Alquiler.FechaEmision,
                        FechaEntrega = d.Alquiler.FechaEntrega,
                        FechaDevolucion = d.Alquiler.FechaDevolucion,

                        Articulo = d.Articulo.Descripcion,
                        Cantidad = d.Cantidad,
                        PrecioUnitario = d.PrecioUnitario,
                        SubtotalDetalle = d.Subtotal,
                        IvaPorcentaje = d.PorcentajeIva,

                        SubtotalFactura = d.Alquiler.SubTotal,
                        IvaTotal = d.Alquiler.IvaTotal,
                        TotalFactura = d.Alquiler.TotalFactura
                    })
                    .ToList();

                dgv.AutoGenerateColumns = true;
                dgv.DataSource = datos;

                CargarHeaders(dgv);
            }
        }

        private static void CargarHeaders(DataGridView dgv)
        {
            dgv.Columns["Factura"].HeaderText = "Nro Factura";
            dgv.Columns["Cliente"].HeaderText = "Cliente";
            dgv.Columns["RUC_CI"].HeaderText = "RUC/CI";
            dgv.Columns["Empleado"].HeaderText = "Empleado";
            dgv.Columns["Estado"].HeaderText = "Estado";

            dgv.Columns["FechaEmision"].HeaderText = "Fecha Emisión";
            dgv.Columns["FechaEntrega"].HeaderText = "Fecha Entrega";
            dgv.Columns["FechaDevolucion"].HeaderText = "Fecha Devolución";

            dgv.Columns["Articulo"].HeaderText = "Artículo";
            dgv.Columns["Cantidad"].HeaderText = "Cantidad";
            dgv.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dgv.Columns["SubtotalDetalle"].HeaderText = "Subtotal Detalle";
            dgv.Columns["IvaPorcentaje"].HeaderText = "IVA %";

            dgv.Columns["SubtotalFactura"].HeaderText = "Subtotal Factura";
            dgv.Columns["IvaTotal"].HeaderText = "IVA Total";
            dgv.Columns["TotalFactura"].HeaderText = "Total Factura";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

