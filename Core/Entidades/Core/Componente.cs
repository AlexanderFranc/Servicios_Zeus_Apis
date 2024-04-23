using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Componente
{
    public int IdComponente { get; set; }

    public int IdPlanEstudio { get; set; }

    public int IdMateria { get; set; }

    public int IdSubtipoComponente { get; set; }

    public string? CodigoComponente { get; set; }

    public double? PesoComponente { get; set; }

    public bool? ActivoComponente { get; set; }

    public int? HorasComponente { get; set; }

    public virtual Materium IdMateriaNavigation { get; set; } = null!;

    public virtual PlanEstudio IdPlanEstudioNavigation { get; set; } = null!;

    public virtual SubtipoComponente IdSubtipoComponenteNavigation { get; set; } = null!;
}
