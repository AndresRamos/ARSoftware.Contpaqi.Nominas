using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class VistaRelacion
{
    public int id { get; set; }

    public int? idtabla { get; set; }

    public int? idtabladestino { get; set; }

    public string? campo { get; set; }

    public string? campodestino { get; set; }
}
