using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class Nom70000
{
    public int idTabla { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public byte TipoZona { get; set; }

    public bool Reportada { get; set; }

    public int Version { get; set; }

    public DateTime TimeStamp { get; set; }
}
