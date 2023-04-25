using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class Asc10003
{
    public string DatabaseName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string FieldValue { get; set; } = null!;

    public string? UserValue { get; set; }
}
