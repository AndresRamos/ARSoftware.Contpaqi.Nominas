using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class Nom10046
{
    public int idFiniquito { get; set; }

    public int idPeriodo { get; set; }

    public int idEmpleado { get; set; }

    public DateTime FechaBaja { get; set; }

    public string ParametrosGenerales { get; set; } = null!;

    public string ConceptosCalculo { get; set; } = null!;

    public bool? Calculado { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime TimeStamp { get; set; }
}
