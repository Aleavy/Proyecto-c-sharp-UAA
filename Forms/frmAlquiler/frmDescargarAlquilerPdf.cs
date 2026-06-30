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

namespace AlquilerApp_Proyecto.Forms.frmAlquiler
{
    public partial class frmDescargarAlquilerPdf : Form
    {
        public frmDescargarAlquilerPdf()
        {
            InitializeComponent();
        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportHelper.ExportarExcel(dgfAlquileres);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ExportHelper.ExportarPdf(dgfAlquileres);
        }

        private void frmDescargarAlquilerPdf_Load(object sender, EventArgs e)
        {
            AlquilerRepository.CargarAlquileresConDetalle(dgfAlquileres);
        }
    }
}
