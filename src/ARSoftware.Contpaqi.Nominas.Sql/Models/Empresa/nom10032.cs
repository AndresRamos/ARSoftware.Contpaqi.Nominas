using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10032
    {
        public int idturno { get; set; }
        public int? numeroturno { get; set; }
        public string? descripcion { get; set; }
        public double? numerohoras { get; set; }
        public DateTime? timestamp { get; set; }
        public string TipoJornada { get; set; } = null!;
    }
}
