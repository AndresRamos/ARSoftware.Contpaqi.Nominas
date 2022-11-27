using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10061
    {
        public int IdMovimiento { get; set; }
        public int IdEnvio { get; set; }
        public int Idempleado { get; set; }
        public DateTime Fecha { get; set; }
        public double SBC { get; set; }
        public string TipoMov { get; set; } = null!;
        public string Estatus { get; set; } = null!;
        public string? TipoError { get; set; }
        public string Error { get; set; } = null!;
        public string NRP { get; set; } = null!;
        public string NSS { get; set; } = null!;
        public string CURP { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public int UMF { get; set; }
        public string TipoContrato { get; set; } = null!;
        public int TipoSemanaReducida { get; set; }
        public string TipoBasecotizacion { get; set; } = null!;
        public string CausaBaja { get; set; } = null!;
        public DateTime? TimeStamp { get; set; }
    }
}
