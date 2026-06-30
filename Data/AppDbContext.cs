using AlquilerApp_Proyecto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Data
{
    public  class AppDbContext  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Data Source =DESKTOP-HSVBM43; Initial Catalog = Alquiler; Integrated Security = True; Encrypt = True; Trust Server Certificate = True"
            );
        }
        public DbSet<Alquiler> Alquiler {  get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleAlquiler> DetalleAlquiler { get; set; }

        public DbSet<TipoDocumento> TipoDocumento{ get; set; }
        public DbSet<EstadoAlquiler> EstadoAlquiler{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
