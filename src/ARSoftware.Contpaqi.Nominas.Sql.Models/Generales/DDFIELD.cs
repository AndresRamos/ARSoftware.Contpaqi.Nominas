using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class DDFIELD
{
    public string databasename { get; set; } = null!;

    public string tablename { get; set; } = null!;

    public string fieldname { get; set; } = null!;

    public string? fieldalias { get; set; }

    public bool selectable { get; set; }

    public bool searchable { get; set; }

    public bool sortable { get; set; }

    public string? displayformat { get; set; }
}
