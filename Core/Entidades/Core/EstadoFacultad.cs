using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoFacultad
{
    public int IdEstadoFacultad { get; set; }

    public string? NombreEstadoFacultad { get; set; }

    public bool? ActivoEstadoFacultad { get; set; }

    public virtual ICollection<Facultad> Facultads { get; } = new List<Facultad>();
}
