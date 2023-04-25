using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10040
{
    public int IdTarjetaCredito { get; set; }

    public int IdEmpleado { get; set; }

    public int IdConcepto { get; set; }

    public string? NumeroControl { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public double? MontoLimite { get; set; }

    public string? Tipo { get; set; }

    public double? Valor { get; set; }

    public int? VecesAplicado { get; set; }

    public int? VecesAplicar { get; set; }

    public double? OtrosPagos { get; set; }

    public double? MontoAcumulado { get; set; }

    public string? Observaciones { get; set; }

    public bool Estado { get; set; }

    public DateTime? TimeStamp { get; set; }
}
