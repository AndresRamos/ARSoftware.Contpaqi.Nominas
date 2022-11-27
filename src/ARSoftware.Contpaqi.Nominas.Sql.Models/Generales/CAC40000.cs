using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class CAC40000
{
    public string IdSistema { get; set; } = null!;

    public string IdProceso { get; set; } = null!;

    public string Identificacion { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Grupo { get; set; }

    public double? Mensaje { get; set; }

    public double? WParam { get; set; }

    public double? LParam { get; set; }
}
