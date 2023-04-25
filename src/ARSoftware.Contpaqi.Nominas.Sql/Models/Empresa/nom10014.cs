using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10014
{
    public int idtcontrolvacaciones { get; set; }

    public int? idempleado { get; set; }

    public int? ejercicio { get; set; }

    public int? diasvacaciones { get; set; }

    public double? diasprimavacacional { get; set; }

    public DateTime? fechainicio { get; set; }

    public DateTime? fechafin { get; set; }

    public string? diasdescanso { get; set; }

    public DateTime? timestamp { get; set; }

    public DateTime? fechapago { get; set; }
}
