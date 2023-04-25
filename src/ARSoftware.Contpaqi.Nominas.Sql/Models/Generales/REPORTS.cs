using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class REPORTS
{
    public string Name { get; set; } = null!;

    public string? DataViewName { get; set; }

    public string? Description { get; set; }

    public byte[]? Template { get; set; }
}
