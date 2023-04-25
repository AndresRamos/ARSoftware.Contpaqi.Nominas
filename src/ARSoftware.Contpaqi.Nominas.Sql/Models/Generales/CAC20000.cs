using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class CAC20000
{
    public string IdSistema { get; set; } = null!;

    public short Nivel { get; set; }

    public string Proceso { get; set; } = null!;

    public string Adicional { get; set; } = null!;
}
