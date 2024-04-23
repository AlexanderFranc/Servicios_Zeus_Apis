using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoFranjaHorario
{
    public int IdEstadoFranjaHorario { get; set; }

    public string? NombreEstadoFranjaHorario { get; set; }

    public bool? ActivoEstadoFranjaHorario { get; set; }

    public virtual ICollection<FranjaHorario> FranjaHorarios { get; } = new List<FranjaHorario>();
}
