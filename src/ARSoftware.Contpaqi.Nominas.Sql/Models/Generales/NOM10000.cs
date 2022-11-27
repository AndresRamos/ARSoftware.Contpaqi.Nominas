using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class NOM10000
    {
        public string NombreEmpresa { get; set; } = null!;
        public int IDEmpresa { get; set; }
        public int? IDCptoPrimaVac { get; set; }
        public int? IDCptoAguinaldo { get; set; }
        public int? IDCptoPTU { get; set; }
        public int? IDCptoVacaciones { get; set; }
        public string? NombreCorto { get; set; }
        public string? RutaEmpresa { get; set; }
        public string? RutaRespaldo { get; set; }
        public string? RutaContpaqW { get; set; }
        public string? RutaCheqpaqW { get; set; }
        public int? IDEmpresaContpaqW { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Telefono3 { get; set; }
        public string? Fax { get; set; }
        public string? RegistroIMSS { get; set; }
        public string? RegistroCamara { get; set; }
        public string? RFC { get; set; }
        public string? Homoclave { get; set; }
        public string? RegistroInfonavit { get; set; }
        public string? RegistroFonacot { get; set; }
        public string? RegistroComisionMixta { get; set; }
        public string? RegistroSSA { get; set; }
        public string? ZonaSalarioGeneral { get; set; }
        public DateTime? FechaInicioHistoria { get; set; }
        public DateTime? FechaConstitucion { get; set; }
        public int? Ejercicio { get; set; }
        public double? PorcentajeSubsidio { get; set; }
        public string? CuentaCWGlobal { get; set; }
        public string? EstructuraCuentaCW { get; set; }
        public string? FormatoSobreRecibo { get; set; }
        public bool? AfectarPeriodosAnteriores { get; set; }
        public bool? AfectarPeriodosFuturos { get; set; }
        public int? PosicionCuentaEmpleado { get; set; }
        public int? LongitudCuentaEmpleado { get; set; }
        public int? PosicionCuentaDepto { get; set; }
        public int? LongitudCuentaDepto { get; set; }
        public string? Localidad { get; set; }
        public string? NombreRepresentante { get; set; }
        public string? ApPaternoRepresentante { get; set; }
        public string? ApMaternoRepresentante { get; set; }
        public string? CodigoPostal { get; set; }
        public string? ApartadoPostal { get; set; }
        public string? MascarillaCodigo { get; set; }
        public int? NumeroDecimales { get; set; }
        public string? TipoCodigoEmpleado { get; set; }
        public bool? MostrarAgenda { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? IDCptoAjuste { get; set; }
        public int? IDCptoIndem20 { get; set; }
        public int? IDCptoIndem90 { get; set; }
        public int? IDCptoPrimaAntig { get; set; }
        public int? IDCptoPrimaVacRep { get; set; }
        public int? IDCptoSueldo { get; set; }
        public int? IDCptoVacRep { get; set; }
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
}
