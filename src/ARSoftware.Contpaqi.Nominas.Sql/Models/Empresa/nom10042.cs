using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10042
{
    public int IdMovtoCredito { get; set; }

    public int IdTarjetaCredito { get; set; }

    public int IdEmpleado { get; set; }

    public int IdPeriodo { get; set; }

    public int IdConcepto { get; set; }

    public double? Importe { get; set; }

    public DateTime? TimeStamp { get; set; }
}
