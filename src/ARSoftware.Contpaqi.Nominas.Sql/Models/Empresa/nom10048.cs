using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10048
    {
        public int IDContratante { get; set; }
        public string RFC { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
    }
}
