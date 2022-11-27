using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales
{
    public partial class Asc10001
    {
        public string DatabaseName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string? TableAlias { get; set; }
        public string? ItemAlias { get; set; }
        public string? MainFields { get; set; }
        public bool Global { get; set; }
        public bool Hidden { get; set; }
    }
}
