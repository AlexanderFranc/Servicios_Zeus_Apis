using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PeriodicidadPlanEstudio
{
    public int IdPeriodicidadPlanEstudios { get; set; }

    public string? NombrePeriodicidadPlanEstudios { get; set; }

    public string? CodigoPeriodicidadPlanEstudios { get; set; }

    public string? DescripcionPeriodicidadPlanEstudios { get; set; }

    public bool? ActivoPeriodicidadPlanEstudios { get; set; }

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();
}
