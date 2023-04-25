using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class Nom20000
{
    public int IDUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Clave { get; set; }

    public string? TipoUsuario { get; set; }

    public string? Acceso { get; set; }
}
