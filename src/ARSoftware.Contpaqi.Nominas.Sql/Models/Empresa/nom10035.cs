using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Nominas.Sql.Models.Empresa;

public partial class nom10035
{
    public int cidregistropatronal { get; set; }

    public string? crfc { get; set; }

    public DateTime? cfechaconstitucion { get; set; }

    public string? chomoclave { get; set; }

    public DateTime? ctimestamp { get; set; }

    public string? crfccompleto { get; set; }

    public string? cregistroimss { get; set; }

    public string? GUIDFirmaDSL { get; set; }

    public string? ClaseRiesgoTrabajo { get; set; }

    public string? FraccionRiesgoTrabajo { get; set; }

    public string? LocalidadRegPatronal { get; set; }

    public string CodigoPostal { get; set; } = null!;

    public string EntidadFederativa { get; set; } = null!;
}
