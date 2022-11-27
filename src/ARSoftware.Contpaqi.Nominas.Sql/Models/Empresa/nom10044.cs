using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10044
    {
        public int idmovtopdo { get; set; }
        public int? idperiodo { get; set; }
        public int? idempleado { get; set; }
        public int? idconcepto { get; set; }
        public int? idmovtopermanente { get; set; }
        public double? importetotal { get; set; }
        public double? valor { get; set; }
        public double? importe1 { get; set; }
        public double? importe2 { get; set; }
        public double? importe3 { get; set; }
        public double? importe4 { get; set; }
        public bool importetotalreportado { get; set; }
        public bool importe1reportado { get; set; }
        public bool importe2reportado { get; set; }
        public bool importe3reportado { get; set; }
        public bool importe4reportado { get; set; }
        public int? idDocumento { get; set; }
        public DateTime? timestamp { get; set; }
        public bool? valorReportado { get; set; }
    }
}
