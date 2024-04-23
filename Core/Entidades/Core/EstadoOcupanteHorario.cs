using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoOcupanteHorario
{
    public int IdEstadoOcupanteHorario { get; set; }

    public string? NombreEstadoOcupanteHorario { get; set; }

    public bool? ActivoEstadoOcupanteHorario { get; set; }

    public virtual ICollection<OcupanteHorario> OcupanteHorarios { get; } = new List<OcupanteHorario>();
}
