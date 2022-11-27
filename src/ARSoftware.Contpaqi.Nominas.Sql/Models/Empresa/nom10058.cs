using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10058
    {
        public int IdCertificado { get; set; }
        public string NPIE { get; set; } = null!;
        public int CidRegistroPatronal { get; set; }
        public int IdUsuario { get; set; }
        public string TipoCertificado { get; set; } = null!;
        public DateTime? TimeStamp { get; set; }
    }
}
