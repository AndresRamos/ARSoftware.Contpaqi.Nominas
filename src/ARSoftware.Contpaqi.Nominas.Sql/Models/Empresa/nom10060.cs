using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10060
{
    public int IdEnvio { get; set; }

    public int IdCertificado { get; set; }

    public string? IdLote { get; set; }

    public string? IdTransaccion { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaEnvio { get; set; }
}
