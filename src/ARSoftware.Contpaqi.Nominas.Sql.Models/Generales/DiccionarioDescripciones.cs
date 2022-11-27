using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class DiccionarioDescripciones
{
    public int IDCampo { get; set; }

    public string Descripcion { get; set; } = null!;
}
