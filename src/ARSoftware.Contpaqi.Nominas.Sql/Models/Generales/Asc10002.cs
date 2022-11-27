using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class Asc10002
    {
        public string DatabaseName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string FieldName { get; set; } = null!;
        public string? FieldAlias { get; set; }
        public bool UserField { get; set; }
        public bool RequiredField { get; set; }
        public string? Index { get; set; }
        public bool NullIndex { get; set; }
    }
}
