using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerApp_Proyecto.Models
{
    public class Articulo
    {
        public int ArticuloId { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string Descripcion { get; set; }
        public int StockDisponible { get; set; }
        public decimal PrecioListaAlquiler { get; set; }
        public decimal PorcentajeIva { get; set; }
        public bool RevisarStock(int cantidad) => StockDisponible >= cantidad;
        public void ReducirStock(int cantidad) => StockDisponible -= cantidad;
        public void ReponerStock(int cantidad) => StockDisponible += cantidad;
    }
}