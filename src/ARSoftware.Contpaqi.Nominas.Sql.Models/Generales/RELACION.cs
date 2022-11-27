using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class RELACION
{
    public string? TablaOrigen { get; set; }

    public string? CampoOrigen { get; set; }

    public string? TablaVer { get; set; }

    public string? CampoVer { get; set; }

    public string? Despliegue { get; set; }

    public string ValorVer { get; set; } = null!;

    public string? BaseDatos { get; set; }
}
