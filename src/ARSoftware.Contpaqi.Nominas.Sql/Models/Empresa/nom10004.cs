using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10004
    {
        public int idconcepto { get; set; }
        public int? numeroconcepto { get; set; }
        public string? tipoconcepto { get; set; }
        public string? descripcion { get; set; }
        public bool especie { get; set; }
        public bool automaticoglobal { get; set; }
        public bool automaticoliquidacion { get; set; }
        public bool imprimir { get; set; }
        public bool articulo86 { get; set; }
        public string? leyendaimporte1 { get; set; }
        public string? leyendaimporte2 { get; set; }
        public string? leyendaimporte3 { get; set; }
        public string? leyendaimporte4 { get; set; }
        public string? cuentacw { get; set; }
        public string? tipomovtocw { get; set; }
        public string? contracuentacw { get; set; }
        public string? contabcuentacw { get; set; }
        public string? contabcontracuentacw { get; set; }
        public string? leyendavalor { get; set; }
        public string? formulaimportetotal { get; set; }
        public string? formulaimporte1 { get; set; }
        public string? formulaimporte2 { get; set; }
        public string? formulaimporte3 { get; set; }
        public string? formulaimporte4 { get; set; }
        public DateTime? timestamp { get; set; }
        public string? FormulaValor { get; set; }
        public string? CuentaGravado { get; set; }
        public string? CuentaExentoDeduc { get; set; }
        public string? CuentaExentoNoDeduc { get; set; }
        public string? ClaveAgrupadoraSAT { get; set; }
        public string? MetodoDePago { get; set; }
        public string TipoClaveSAT { get; set; } = null!;
        public string TipoHoras { get; set; } = null!;
    }
}
