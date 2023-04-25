using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10019
{
    public int idempleado { get; set; }

    public DateTime fecha { get; set; }

    public string tiposueldo { get; set; } = null!;

    public double? sueldo { get; set; }

    public int? cidperiodo { get; set; }

    public int? cidtipoperiodo { get; set; }
}
