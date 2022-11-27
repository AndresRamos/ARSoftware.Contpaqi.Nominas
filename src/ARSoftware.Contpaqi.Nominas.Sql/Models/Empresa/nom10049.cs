using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10049
    {
        public int IDRelacion { get; set; }
        public int IDEmpleado { get; set; }
        public int IDContratante { get; set; }
        public double PorcentajeTiempo { get; set; }
    }
}
