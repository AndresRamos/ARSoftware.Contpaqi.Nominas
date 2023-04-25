using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class DDTABLE
{
    public string databasename { get; set; } = null!;

    public string tablename { get; set; } = null!;

    public string? tablealias { get; set; }

    public string? group { get; set; }
}
