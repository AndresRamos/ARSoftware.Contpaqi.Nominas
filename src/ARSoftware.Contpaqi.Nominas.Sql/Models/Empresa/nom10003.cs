using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10003
{
    public int iddepartamento { get; set; }

    public int? numerodepartamento { get; set; }

    public string? descripcion { get; set; }

    public string? beneficiario { get; set; }

    public string? cuentacw { get; set; }

    public DateTime? timestamp { get; set; }

    public string? csegmentonegocio { get; set; }
}
