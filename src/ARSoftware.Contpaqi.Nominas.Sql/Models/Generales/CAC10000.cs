using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class CAC10000
    {
        public string IdSistema { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Password { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public short? Nivel { get; set; }
    }
}
