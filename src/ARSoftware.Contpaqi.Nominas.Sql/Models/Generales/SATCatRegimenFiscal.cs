using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class SATCatRegimenFiscal
    {
        public string ClaveRegimenFiscal { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool? PersonaFisica { get; set; }
        public bool? PersonaMoral { get; set; }
    }
}
