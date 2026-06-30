using AlquilerApp_Proyecto.Data;
using AlquilerApp_Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerApp_Proyecto.Repositories
{
    public class TipoDocumentoRepository
    {
        public List<TipoDocumento> listarTiposDocumentos()
        {
            List<TipoDocumento> tipoDocumentos;

            // Consulta a la base de datos para obtener la lista de clientes en forma ascendente por ClienteId
            try
            {
                using (var context = new AppDbContext())
                {
                    tipoDocumentos = context.TipoDocumento.ToList();
                    return tipoDocumentos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de documento: " + ex.Message);
            }
            
        }
    }
}
