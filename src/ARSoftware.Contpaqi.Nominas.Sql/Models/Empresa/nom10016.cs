using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10016
{
    public int idmovtopoliza { get; set; }

    public int? idpoliza { get; set; }

    public string? cuentacw { get; set; }

    public int? numeromovto { get; set; }

    public string? referencia { get; set; }

    public string? concepto { get; set; }

    public string? tipomovto { get; set; }

    public double? cargo { get; set; }

    public double? abono { get; set; }

    public double? cargomonedaext { get; set; }

    public double? abonomonedaext { get; set; }

    public string? diario { get; set; }

    public string? csegmentonegocio { get; set; }

    public string? GUIDMovtoPoliza { get; set; }
}
