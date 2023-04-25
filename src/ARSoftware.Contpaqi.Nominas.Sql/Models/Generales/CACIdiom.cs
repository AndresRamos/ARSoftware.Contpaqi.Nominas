using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class CACIdiom
{
    public int NumeroSistema { get; set; }

    public int NumeroIdioma { get; set; }

    public string? NombreIdioma { get; set; }

    public string? NombreDLLApp { get; set; }

    public string? NombreDLLErr { get; set; }

    public string? NombreArchivoAyuda { get; set; }

    public string? NombreArchivoBDD { get; set; }

    public int? IdAyuda { get; set; }
}
