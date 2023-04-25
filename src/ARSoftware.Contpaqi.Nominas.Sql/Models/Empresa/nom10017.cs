using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10017
{
    public int idmovtopermanente { get; set; }

    public int? idempleado { get; set; }

    public int? idconcepto { get; set; }

    public string? descripcion { get; set; }

    public string? tipo { get; set; }

    public double? valor { get; set; }

    public int? vecesaplicar { get; set; }

    public int? vecesaplicado { get; set; }

    public double? montolimite { get; set; }

    public double? montoacumulado { get; set; }

    public double? montoacumuladoejeant { get; set; }

    public DateTime? fecharegistro { get; set; }

    public string? numerocontrol { get; set; }

    public bool estado { get; set; }

    public DateTime? timestamp { get; set; }

    public int? numerofiltro { get; set; }

    public DateTime? fechainiciotarjeta { get; set; }
}
