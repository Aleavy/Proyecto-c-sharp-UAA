using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlquilerApp_Proyecto.Models
{
    public class DetalleAlquiler
    {
        [Key]
      
       
        public int DetalleId { get; set; }
        public int AlquilerId { get; set; }
        public Alquiler Alquiler { get; set; }
        public int ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public decimal PorcentajeIva { get; set; }


       /*
        public decimal CalcularSubTotal() => Cantidad * PrecioUnitario;

        public decimal CalcularIva() => Subtotal * 0.1m;
        */
    }
}