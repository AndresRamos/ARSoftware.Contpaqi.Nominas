using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class FechaCatalogos
{
    public string TipoCatalogos { get; set; } = null!;

    public DateTime UltimaActualizacion { get; set; }
}
