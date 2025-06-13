using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class SekMallasComponente
{
    public int? IdNivelEstudio { get; set; }

    public string? NombreNivelEstudio { get; set; }

    public int IdCarrera { get; set; }

    public string? CodigoCarrera { get; set; }

    public string? NombreCarrera { get; set; }

    public string? CodigoPlanEstudioMalla { get; set; }

    public string? NombreModalidadPe { get; set; }

    public string? CodigoMateria { get; set; }

    public string? NombreMateria { get; set; }

    public int? IdUoc { get; set; }

    public string? CodigoUoc { get; set; }

    public string? NombreUoc { get; set; }

    public int? Nivel { get; set; }

    public double? CreditosMateria { get; set; }

    public int? HorasSemestralesMateria { get; set; }

    public int? AcD { get; set; }

    public int? AcDc { get; set; }

    public int? ApeSd { get; set; }

    public int? ApeD { get; set; }

    public int? ApeDe { get; set; }

    public int? ApeA { get; set; }

    public int? ApeDc { get; set; }

    public int? Aa { get; set; }
}
