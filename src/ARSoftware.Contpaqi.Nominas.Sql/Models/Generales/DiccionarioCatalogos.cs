using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class DiccionarioCatalogos
    {
        public int IDCampo { get; set; }
        public string Catalogo { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string CampoBD { get; set; } = null!;
        public string CampoImportacion { get; set; } = null!;
        public bool Obligatorio { get; set; }
        public int OrdenExportacion { get; set; }
        public bool Actualizable { get; set; }
    }
}
