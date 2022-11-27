using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nomsimul
    {
        public int idresultado { get; set; }
        public int? idempleado { get; set; }
        public string? nombre { get; set; }
        public string? ids { get; set; }
        public string? consecutivo { get; set; }
        public string? tipo { get; set; }
        public string? expresion { get; set; }
        public double? resultado { get; set; }
    }
}
