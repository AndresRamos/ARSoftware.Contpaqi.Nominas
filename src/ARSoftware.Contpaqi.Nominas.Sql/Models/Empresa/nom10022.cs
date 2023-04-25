using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10022
{
    public int idtipoincidencia { get; set; }

    public string? descripcion { get; set; }

    public string? mnemonico { get; set; }

    public bool derechosueldo { get; set; }

    public double? porcentajesueldo { get; set; }

    public string? tipoimss { get; set; }

    public string? tipoincidencia { get; set; }

    public bool derechoseptimodia { get; set; }

    public DateTime? timestamp { get; set; }

    public double? valorunidad { get; set; }
}
