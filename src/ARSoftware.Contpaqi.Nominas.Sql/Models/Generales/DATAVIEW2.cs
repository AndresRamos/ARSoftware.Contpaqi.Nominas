using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class DATAVIEW2
{
    public string? Name { get; set; }

    public string? ClassName { get; set; }

    public string? ClassDescription { get; set; }

    public string? Description { get; set; }

    public byte[]? Template { get; set; }
}
