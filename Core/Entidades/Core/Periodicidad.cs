using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Periodicidad
{
    public int IdPeriodicidad { get; set; }

    public string? NombrePeriodicidad { get; set; }

    public bool? ActivoPeriodicidad { get; set; }

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();
}
