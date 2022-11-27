using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class NomIDX
{
    public string? Tabla { get; set; }

    public string? Indice { get; set; }

    public string? Columnas { get; set; }

    public bool Descendente { get; set; }
}
