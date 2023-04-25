using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10018
{
    public int idtarjetaincapacidad { get; set; }

    public int? idtipoincidencia { get; set; }

    public int? idempleado { get; set; }

    public string? folio { get; set; }

    public int? diasautorizados { get; set; }

    public DateTime? fechainicio { get; set; }

    public string? descripcion { get; set; }

    public string? incapacidadinicial { get; set; }

    public string? ramoseguro { get; set; }

    public string? tiporiesgo { get; set; }

    public int? numerocaso { get; set; }

    public bool fincaso { get; set; }

    public double? porcentajeincapacidad { get; set; }

    public bool controlmaternidad { get; set; }

    public string? nombremedico { get; set; }

    public string? matriculamedico { get; set; }

    public string? circunstancia { get; set; }

    public DateTime? timestamp { get; set; }

    public string? controlincapacidad { get; set; }

    public string? secuelaconsecuencia { get; set; }
}
