using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PlanificacionCompartida
{
    public int Id { get; set; }

    public int IdPeriodo { get; set; }

    public int IdMalla { get; set; }

    public int IdPlanEstudio { get; set; }

    public int IdMateria { get; set; }

    public int? IdPlanificacion { get; set; }

    public int IdPlanificacionPrincipal { get; set; }

    public string Paralelo { get; set; } = null!;

    public string Uc { get; set; } = null!;

    public DateTime Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public bool Activo { get; set; }
}
