using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class CAC50000
    {
        public string IdSistema { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
