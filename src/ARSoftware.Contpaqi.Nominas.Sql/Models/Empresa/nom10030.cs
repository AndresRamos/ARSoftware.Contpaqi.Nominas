using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10030
    {
        public int idcategoria { get; set; }
        public string? nombre { get; set; }
        public string? grupo { get; set; }
        public string? tipo { get; set; }
        public int? posicion { get; set; }
        public DateTime? timestamp { get; set; }
        public bool cpropia { get; set; }
    }
}
