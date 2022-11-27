using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class Asc10004
    {
        public string DatabaseName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string FieldName { get; set; } = null!;
        public string? LookupTable { get; set; }
        public string? LookupField { get; set; }
        public int? Priority { get; set; }
    }
}
