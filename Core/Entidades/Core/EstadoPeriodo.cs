using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoPeriodo
{
    public int IdEstadoPeriodo { get; set; }

    public string? NombreEstadoPeriodo { get; set; }

    public bool? ActivoEstadoPeriodo { get; set; }

    public virtual ICollection<Periodo> Periodos { get; } = new List<Periodo>();
}
