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

    public string Modalidad { get; set; } = null!;

    public string? CodigoMateria { get; set; }

    public string? NombreMateria { get; set; }

    public int? NivelMateria { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public string? Profesor { get; set; }

    public string Paralelo { get; set; } = null!;

    public string? CodigoEspaciosFisicos { get; set; }

    public string? NombreDia { get; set; }

    public string? HIni { get; set; }

    public string? HFin { get; set; }

    public string? CodigoSubtipoComponente { get; set; }

    public string? NombreSubtipoComponente { get; set; }
}
