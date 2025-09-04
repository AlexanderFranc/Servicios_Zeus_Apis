using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InfoPlanificacion
{
    public string? CodigoPeriodo { get; set; }

    public string? CodigoTextoPeriodo { get; set; }

    public int IdPlanificacion { get; set; }

    public string? CodigoFacultad { get; set; }

    public string? NombreFacultad { get; set; }

    public string? CodigoCarrera { get; set; }

    public string? NombreCarrera { get; set; }

    public string? CodigoPlanEstudioMalla { get; set; }

    public string ModPlan { get; set; } = null!;

    public string TipoPlan { get; set; } = null!;

    public string TipoPlanificacion { get; set; } = null!;

    public string? CodigoMateria { get; set; }

    public string? NombreMateria { get; set; }

    public int? NivelMateria { get; set; }

    public double? CreditosMateria { get; set; }

    public int? HorasSemestralesMateria { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public string? Profesor { get; set; }

    public string Paralelo { get; set; } = null!;

    public string? CodigoEspaciosFisicos { get; set; }

    public string? PDia { get; set; }

    public string? PHIni { get; set; }

    public string? PHFin { get; set; }

    public DateTime? MFecha { get; set; }

    public string? MHIni { get; set; }

    public string? MHFin { get; set; }

    public string? CodigoSubtipoComponente { get; set; }

    public int? HorasComponente { get; set; }
}
