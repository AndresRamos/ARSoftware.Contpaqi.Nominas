using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10015
{
    public int idpoliza { get; set; }

    public int? idperiodo { get; set; }

    public string? estadocontab { get; set; }

    public DateTime? fechapoliza { get; set; }

    public int? tipopoliza { get; set; }

    public int? numeropoliza { get; set; }

    public string? concepto { get; set; }

    public string? diario { get; set; }

    public string? GUIDPoliza { get; set; }
}
