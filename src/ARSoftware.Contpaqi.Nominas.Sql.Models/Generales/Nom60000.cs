using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class Nom60000
{
    public int NumeroTabla { get; set; }

    public int NumeroColumna { get; set; }

    public int NumeroRenglon { get; set; }

    public double? Valor { get; set; }

    public DateTime? Fecha { get; set; }
}
