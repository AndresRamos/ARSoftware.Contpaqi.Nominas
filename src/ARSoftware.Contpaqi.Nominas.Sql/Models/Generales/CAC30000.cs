using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class CAC30000
{
    public string IdSistema { get; set; } = null!;

    public short Perfil { get; set; }

    public string? Descripcion { get; set; }
}
