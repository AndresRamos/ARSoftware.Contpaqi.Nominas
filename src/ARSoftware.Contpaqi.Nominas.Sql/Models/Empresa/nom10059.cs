using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10059
{
    public string Tipo { get; set; } = null!;

    public string? IdLote { get; set; }

    public string? NombreArchivo { get; set; }

    public byte[] Archivo { get; set; } = null!;

    public int IdCertificado { get; set; }
}
