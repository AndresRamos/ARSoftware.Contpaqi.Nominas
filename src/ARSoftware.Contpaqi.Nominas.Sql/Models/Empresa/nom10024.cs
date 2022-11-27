using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10024
    {
        public int iddispfiscal { get; set; }
        public string? tipo { get; set; }
        public string? descripcion { get; set; }
        public string? ruta { get; set; }
        public string? fechainicio { get; set; }
        public string? frecuencia { get; set; }
        public bool activada { get; set; }
        public DateTime? timestamp { get; set; }
    }
}
