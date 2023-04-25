using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10034
{
    public int idempleado { get; set; }

    public int idtipoperiodo { get; set; }

    public int cidperiodo { get; set; }

    public int? iddepartamento { get; set; }

    public int? idpuesto { get; set; }

    public int? idturno { get; set; }

    public string? estadocivil { get; set; }

    public int? umf { get; set; }

    public string? cuentapagoelectronico { get; set; }

    public string? sucursalpagoelectronico { get; set; }

    public string? bancopagoelectronico { get; set; }

    public string? estadoempleado { get; set; }

    public double? sueldodiario { get; set; }

    public DateTime? fechasueldodiario { get; set; }

    public double? sueldovariable { get; set; }

    public DateTime? fechasueldovariable { get; set; }

    public double? sueldopromedio { get; set; }

    public DateTime? fechasueldopromedio { get; set; }

    public double? sueldointegrado { get; set; }

    public DateTime? fechasueldointegrado { get; set; }

    public bool calculado { get; set; }

    public bool? afectado { get; set; }

    public bool calculadoextraordinario { get; set; }

    public bool? afectadoextraordinario { get; set; }

    public bool interfazcheqpaqw { get; set; }

    public bool modificacionneto { get; set; }

    public DateTime? fechaalta { get; set; }

    public string? cuentacw { get; set; }

    public string? tipocontrato { get; set; }

    public string? basecotizacionimss { get; set; }

    public string? tipoempleado { get; set; }

    public string? basepago { get; set; }

    public string? formapago { get; set; }

    public string? zonasalario { get; set; }

    public bool modificacionsalarioimss { get; set; }

    public bool altaimss { get; set; }

    public bool bajaimss { get; set; }

    public bool cambiocotizacionimss { get; set; }

    public string? telefono { get; set; }

    public string? codigopostal { get; set; }

    public string? direccion { get; set; }

    public string? poblacion { get; set; }

    public string? estado { get; set; }

    public string? numeroafore { get; set; }

    public DateTime? fechabaja { get; set; }

    public string? causabaja { get; set; }

    public double? sueldobaseliquidacion { get; set; }

    public string? campoextra1 { get; set; }

    public string? campoextra2 { get; set; }

    public string? campoextra3 { get; set; }

    public DateTime? fechareingreso { get; set; }

    public double? ajustealneto { get; set; }

    public DateTime? timestamp { get; set; }

    public int? cidregistropatronal { get; set; }

    public string? cestadoempleadoperiodo { get; set; }

    public double? ccampoextranumerico1 { get; set; }

    public double? ccampoextranumerico2 { get; set; }

    public double? ccampoextranumerico3 { get; set; }

    public double? ccampoextranumerico4 { get; set; }

    public double? ccampoextranumerico5 { get; set; }

    public double? cdiastrabajados { get; set; }

    public double? cdiaspagados { get; set; }

    public double? cdiascotizados { get; set; }

    public double? cdiasausencia { get; set; }

    public double? cdiasincapacidades { get; set; }

    public double? cdiasvacaciones { get; set; }

    public double? cdiaspropseptimos { get; set; }

    public double? chorasextras1 { get; set; }

    public double? chorasextras2 { get; set; }

    public double? chorasextras3 { get; set; }

    public DateTime? cfechasueldomixto { get; set; }

    public double? csueldomixto { get; set; }

    public DateTime? cfechacorte { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? ClabeInterbancaria { get; set; }

    public int TipoPrestacion { get; set; }

    public int TipoSemanaReducida { get; set; }
}
