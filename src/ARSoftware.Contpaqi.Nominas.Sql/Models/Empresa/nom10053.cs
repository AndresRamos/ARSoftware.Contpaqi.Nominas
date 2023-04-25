using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10053
{
    public int idempleado { get; set; }

    public int cidperiodo { get; set; }

    public bool cdiastrabajadosreportado { get; set; }

    public bool cdiaspagadosreportado { get; set; }

    public bool cdiascotizadosreportado { get; set; }

    public bool cdiaspropseptimosreportado { get; set; }

    public DateTime timestamp { get; set; }
}
