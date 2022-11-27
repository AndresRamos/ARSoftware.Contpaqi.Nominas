using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10051
    {
        public int IDTablaPrestacion { get; set; }
        public int Antiguedad { get; set; }
        public double DiasVacaciones { get; set; }
        public double DiasAguinaldo { get; set; }
        public double PorcentajePrima { get; set; }
        public double DiasAntiguedad { get; set; }
        public double FactorIntegracion { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
