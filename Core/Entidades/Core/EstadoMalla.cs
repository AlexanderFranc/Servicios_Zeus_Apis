using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoMalla
{
    public int IdEstadoMalla { get; set; }

    public string? NombreEstadoMalla { get; set; }

    public bool? ActivoEstadoMalla { get; set; }

    public virtual ICollection<Malla> Mallas { get; } = new List<Malla>();
}
