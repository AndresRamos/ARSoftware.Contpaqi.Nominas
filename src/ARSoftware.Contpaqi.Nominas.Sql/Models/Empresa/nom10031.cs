using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10031
{
    public int idformula { get; set; }

    public int? idcategoria { get; set; }

    public string? nombre { get; set; }

    public string? tipo { get; set; }

    public int? posicion { get; set; }

    public string? descripcion { get; set; }

    public string? ayuda { get; set; }

    public string? expresion { get; set; }

    public bool modificado { get; set; }

    public DateTime? timestamp { get; set; }

    public int? version { get; set; }
}
