using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Models
{
    public class AlquilerDetalleDTO : INotifyPropertyChanged
    {
        private int _cantidad;
        private decimal _precioUnitario;
        public string Descripcion{ get; set; }  
        public int ArticuloId { get; set; }

        public int Cantidad
        {
            get => _cantidad;
            set { _cantidad = value; OnPropertyChanged(nameof(Importe)); }
        }

        public decimal PrecioUnitario
        {
            get => _precioUnitario;
            set { _precioUnitario = value; OnPropertyChanged(nameof(Importe)); }
        }
        public decimal PorcentajeIVA { get; set; }
        // Propiedad calculada automática
        public decimal Importe => Cantidad * PrecioUnitario;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
