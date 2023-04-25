using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10054
{
    public int IdAviso { get; set; }

    public string NRP { get; set; } = null!;

    public string NSS { get; set; } = null!;

    public string RFCTrabajador { get; set; } = null!;

    public string FolioAviso { get; set; } = null!;

    public string NumCredito { get; set; } = null!;

    public string TipoAviso { get; set; } = null!;

    public DateTime FechaNotLinea { get; set; }

    public DateTime FechaOtorgamiento { get; set; }

    public DateTime FechaCreaAviso { get; set; }

    public string NSSUnificado { get; set; } = null!;

    public string TipoCredito { get; set; } = null!;

    public string TipoDescuento { get; set; } = null!;

    public double FacDescuento { get; set; }

    public double MonDescuento { get; set; }

    public string EstatusCredito { get; set; } = null!;

    public string CURPTrabajador { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public DateTime FechaUltimoAviso { get; set; }
}
