using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa
{
    public partial class nom10062
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string CorreoCliente { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Identificador { get; set; } = null!;
        public bool Habilitado { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
