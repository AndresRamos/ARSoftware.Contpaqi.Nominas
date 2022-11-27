using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10052
    {
        public int IdCambioTipoPer { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaInicioAplicacion { get; set; }
        public DateTime FechaFinAplicacion { get; set; }
        public int IdTipoPeriodo { get; set; }
        public int IdCambioAnterior { get; set; }
        public bool Autorizado { get; set; }
        public bool Vigente { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
