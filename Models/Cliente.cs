using System;
using System.Collections.Generic;
using System.Text;

namespace AlquilerApp_Proyecto.Models;

public class Cliente
{
    public int ClienteId { get; set; }
    public string RazonSocial { get; set; }
    public string Documento { get; set; } 
    public int TipoDocumentoId { get; set; }
    public TipoDocumento TipoDocumento { get; set; }
    public string Telefono { get; set; }
    public string DireccionEntrega { get; set; }

    public Cliente() { }

    public Cliente(int clienteid, string Documento, string razonSocial, TipoDocumento TipoDocumento, string telefono, string direccionEntrega)
    {
        this.ClienteId = clienteid;
        this.RazonSocial = razonSocial;
        this.TipoDocumentoId = TipoDocumento.TipoDocumentoId;
        this.TipoDocumento = TipoDocumento;
        this.Documento = Documento;
        this.Telefono = telefono;
        this.DireccionEntrega = direccionEntrega;
    }
    public string ObtenerInformacionContacto()
    {
        return $"{RazonSocial} {Documento} - Tel: {Telefono}, Email: {DireccionEntrega}";
    }
}

