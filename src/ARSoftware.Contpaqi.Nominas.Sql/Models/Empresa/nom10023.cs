using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10023
{
    public int idtipoperiodo { get; set; }

    public string? nombretipoperiodo { get; set; }

    public int? diasdelperiodo { get; set; }

    public double? diasdepago { get; set; }

    public int? periodotrabajo { get; set; }

    public bool modificarhistoria { get; set; }

    public bool ajustarperiodoscalendario { get; set; }

    public int? numeroseptimos { get; set; }

    public string? posicionseptimos { get; set; }

    public int? posicionpagonomina { get; set; }

    public DateTime? fechainicioejercicio { get; set; }

    public int? ejercicio { get; set; }

    public DateTime? timestamp { get; set; }

    public int? ccalculomescalendario { get; set; }

    public string PeriodicidadPago { get; set; } = null!;
}
