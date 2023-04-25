using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10043
{
    public int IdDocumento { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdPeriodo { get; set; }

    public int? TipoDocumento { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaPago { get; set; }

    public DateTime? FechaEmision { get; set; }

    public double? NumDiasPagados { get; set; }

    public int? DiasAntiguedad { get; set; }

    public string UUID { get; set; } = null!;

    public string GUIDDocumentoDSL { get; set; } = null!;

    public string GUIDDocumento { get; set; } = null!;

    public int? Enviado { get; set; }

    public DateTime? FechaInicialPago { get; set; }

    public DateTime? FechaFinalPago { get; set; }

    public DateTime? FechaInicioRelLaboral { get; set; }

    public double? SBC { get; set; }

    public DateTime? TimeStamp { get; set; }

    public double? NumAnosServicio { get; set; }

    public bool? RelacionarCFDICancelado { get; set; }

    public bool? HayRelacionCFDICancelado { get; set; }

    public string Confirmacion { get; set; } = null!;

    public string URLCaptcha { get; set; } = null!;

    public string vComplemento { get; set; } = null!;

    public string vComprobante { get; set; } = null!;

    public string MotivoCancelacion { get; set; } = null!;
}
