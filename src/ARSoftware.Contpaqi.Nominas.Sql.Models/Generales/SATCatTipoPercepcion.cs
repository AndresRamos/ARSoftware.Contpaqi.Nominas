using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class SATCatTipoPercepcion
{
    public string ClaveTipoPercepcion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string VersionAplica { get; set; } = null!;
}
