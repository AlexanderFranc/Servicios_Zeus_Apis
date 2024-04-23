using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Profesor
{
    public string DniProfesorc { get; set; } = null!;

    public bool? ActivoProfesorc { get; set; }

    public bool? PricipalProfesorc { get; set; }

    public virtual ICollection<Nota> Nota { get; } = new List<Nota>();

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();
}
