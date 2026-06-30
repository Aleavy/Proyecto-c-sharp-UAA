using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Models
{
    public class FacturaBusquedaDTO
    {
            public int AlquilerId { get; set; }
            public string NroFactura { get; set; }
            public int ClienteId { get; set; }
            public string RUC_CI { get; set; }
            public string RazonSocial { get; set; } 
            public DateTime FechaEmision { get; set; }
            public decimal TotalFactura { get; set; }
    }
}
