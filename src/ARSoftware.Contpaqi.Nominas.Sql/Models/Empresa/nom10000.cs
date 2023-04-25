using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10000
{
    public int? idcptoprimavac { get; set; }

    public int? idcptoaguinaldo { get; set; }

    public int? idcptoptu { get; set; }

    public int? idcptovacaciones { get; set; }

    public string? nombrecorto { get; set; }

    public string? rutarespaldo { get; set; }

    public string? rutacontpaqw { get; set; }

    public string? rutacheqpaqw { get; set; }

    public int? idempresacontpaqw { get; set; }

    public string? direccion { get; set; }

    public string? telefono1 { get; set; }

    public string? telefono2 { get; set; }

    public string? telefono3 { get; set; }

    public string? fax { get; set; }

    public string? registroimss { get; set; }

    public string? registrocamara { get; set; }

    public string? rfc { get; set; }

    public string? homoclave { get; set; }

    public string? registroinfonavit { get; set; }

    public string? registrofonacot { get; set; }

    public string? registrocomisionmixta { get; set; }

    public string? registrossa { get; set; }

    public string? zonasalariogeneral { get; set; }

    public DateTime? fechainiciohistoria { get; set; }

    public DateTime? fechaconstitucion { get; set; }

    public int? ejercicio { get; set; }

    public double? porcentajesubsidio { get; set; }

    public string? cuentacwglobal { get; set; }

    public string? estructuracuentacw { get; set; }

    public string? formatosobrerecibo { get; set; }

    public bool? afectarperiodosanteriores { get; set; }

    public bool? afectarperiodosfuturos { get; set; }

    public int? posicioncuentaempleado { get; set; }

    public int? longitudcuentaempleado { get; set; }

    public int? posicioncuentadepto { get; set; }

    public int? longitudcuentadepto { get; set; }

    public string? localidad { get; set; }

    public string? nombrerepresentante { get; set; }

    public string? appaternorepresentante { get; set; }

    public string? apmaternorepresentante { get; set; }

    public string? codigopostal { get; set; }

    public string? apartadopostal { get; set; }

    public string? mascarillacodigo { get; set; }

    public int? numerodecimales { get; set; }

    public string? tipocodigoempleado { get; set; }

    public bool? mostraragenda { get; set; }

    public DateTime? timestamp { get; set; }

    public int? idcptoajuste { get; set; }

    public int? idcptoindem20 { get; set; }

    public int? idcptoindem90 { get; set; }

    public int? idcptoprimaantig { get; set; }

    public int? idcptoprimavacrep { get; set; }

    public int? idcptosueldo { get; set; }

    public int? idcptovacrep { get; set; }

    public double? FactorNoDeducExento { get; set; }

    public string GUIDEmpresa { get; set; } = null!;

    public string GUIDDSL { get; set; } = null!;

    public int? EmitirRecibo { get; set; }

    public string? RegimenFiscal { get; set; }

    public int? OrigenDSL { get; set; }

    public string FormatoSobreReciboCFDI { get; set; } = null!;

    public string CURP { get; set; } = null!;

    public string vConfigComprobante { get; set; } = null!;

    public string vUltTimbreComprobante { get; set; } = null!;

    public string vConfigComplemento { get; set; } = null!;

    public string vUltTimbreComplemento { get; set; } = null!;

    public string OrigenRecursos { get; set; } = null!;

    public bool contratista { get; set; }

    public bool? DatosVigente { get; set; }

    public string RelacionarCFDI { get; set; } = null!;

    public string GUIDEmpresaOrigen { get; set; } = null!;

    public bool EditarFechaPago { get; set; }

    public bool? FiniquitoDividido { get; set; }

    public int TipoCalculoISR { get; set; }

    public string NombreEmpresaFiscal { get; set; } = null!;
}
