using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10021
    {
        public int idtipoacumulado { get; set; }
        public string nombre { get; set; } = null!;
        public string tipomovtoacumulado { get; set; } = null!;
        public DateTime? timestamp { get; set; }
    }
}
