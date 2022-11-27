using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class CAC80000
{
    public string? TablaOrigen { get; set; }

    public string? CampoOrigen { get; set; }

    public string? TablaVer { get; set; }

    public string? CampoVer { get; set; }

    public string? Despliegue { get; set; }

    public int? ValorVer { get; set; }

    public string? BaseDatos { get; set; }

    public string? Indice { get; set; }
}
