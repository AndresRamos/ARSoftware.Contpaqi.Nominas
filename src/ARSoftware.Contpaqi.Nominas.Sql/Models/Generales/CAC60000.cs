using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class CAC60000
{
    public DateTime? Fecha { get; set; }

    public DateTime? Hora { get; set; }

    public string? Usuario { get; set; }

    public string? Proceso { get; set; }

    public string? Datos { get; set; }
}
