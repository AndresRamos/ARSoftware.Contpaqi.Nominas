using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class Nom80000
{
    public int idDetalleTabla { get; set; }

    public int idTabla { get; set; }

    public string DescripcionRango { get; set; } = null!;

    public double Porcentaje { get; set; }

    public double ImporteInicial { get; set; }

    public DateTime TimeStamp { get; set; }
}
