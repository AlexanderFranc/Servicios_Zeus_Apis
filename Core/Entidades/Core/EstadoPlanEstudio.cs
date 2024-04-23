using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoPlanEstudio
{
    public int IdEstadoPe { get; set; }

    public string? NombreEstadoPe { get; set; }

    public string? ObservacionEstadoPe { get; set; }

    public bool? ActivoEstadoPe { get; set; }

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();
}
