using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Generales;

public partial class NOM30000
{
    public string NombreFiltro { get; set; } = null!;

    public string? FiltroReal { get; set; }

    public string? FiltroUsuario { get; set; }

    public string? FiltroModificable { get; set; }

    public string? ListaCampos { get; set; }

    public string? CamposAgrupar { get; set; }

    public int? IdEmpresa { get; set; }

    public int? NumeroFiltro { get; set; }

    public string? Origen { get; set; }
}
