using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class INFONAVITCatSmyUmi
    {
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public string? Medida { get; set; }
        public double? ValorUMI { get; set; }
    }
}
