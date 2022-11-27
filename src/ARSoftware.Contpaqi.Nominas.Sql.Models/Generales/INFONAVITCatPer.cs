using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class INFONAVITCatPer
{
    public int? Ejercicio { get; set; }

    public int? Bimestre { get; set; }

    public DateTime? FechaInicialBimestre { get; set; }

    public DateTime? FechaFinalBimestre { get; set; }

    public int? DiasBimestre { get; set; }

    public DateTime? FechaLimitePago { get; set; }
}
