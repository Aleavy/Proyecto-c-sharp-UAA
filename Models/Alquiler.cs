using AlquilerApp_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlquilerApp_Proyecto.Models
{
    public class Alquiler
    {
        
        public int AlquilerId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaDevolucion { get; set; }   
        public List<DetalleAlquiler> Detalles { get; set; } = new List<DetalleAlquiler>();
        public decimal TotalFactura { get; set; }
        public int EstadoId { get; set; }
        public EstadoAlquiler Estado { get; set; } 
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string NroFactura { get; set; }
        public string RUC_CI{ get; set; }
        public decimal SubTotal { get; set; }
        public decimal IvaTotal { get; set; }
        /*
       public void AgregarDetalle(DetalleAlquiler detalle)
       {
           Detalles.Add(detalle);
       }

       public decimal CalcularTotal()
       {
           TotalFactura = Detalles.Sum(d => d.CalcularSubTotal()) + Detalles.Sum(d => d.CalcularSubTotal()) * 0.1m;
           return TotalFactura;
       }
         */
    }
}
