using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10055
{
    public int IdModificacion { get; set; }

    public double Descuento { get; set; }

    public DateTime FechaEntradaEnVigor { get; set; }

    public byte TipoModificacion { get; set; }

    public bool RegistroActivo { get; set; }
}
