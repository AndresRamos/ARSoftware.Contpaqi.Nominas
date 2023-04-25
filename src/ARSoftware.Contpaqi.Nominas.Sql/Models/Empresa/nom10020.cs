using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10020
{
    public int idbajareingreso { get; set; }

    public int? idempleado { get; set; }

    public string? clavebajareingreso { get; set; }

    public DateTime? fecha { get; set; }

    public int? cidperiodo { get; set; }

    public int? cidtipoperiodo { get; set; }
}
