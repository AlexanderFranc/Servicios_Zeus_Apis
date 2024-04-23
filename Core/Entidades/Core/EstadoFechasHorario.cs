using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoFechasHorario
{
    public int IdEstadoFechasHorario { get; set; }

    public string? NombreEstadoFechasHorario { get; set; }

    public bool? ActivoEstadoFechasHorario { get; set; }

    public virtual ICollection<FechasHorario> FechasHorarios { get; } = new List<FechasHorario>();
}
