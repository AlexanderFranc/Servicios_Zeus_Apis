using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class OcupanteHorario
{
    public int IdOcupanteHorario { get; set; }

    public int? IdEspaciosFisicos { get; set; }

    public int? IdEstadoOcupanteHorario { get; set; }

    public string? DniOcupanteHorario { get; set; }

    public DateTime? FechaiOcupanteHorario { get; set; }

    public DateTime? FechafOcupanteHorario { get; set; }

    public string? ObservacionesOcupanteHorario { get; set; }

    public bool? ActivoOcupanteHorario { get; set; }

    public virtual ICollection<DetalleOcupanteHorario> DetalleOcupanteHorarios { get; } = new List<DetalleOcupanteHorario>();

    public virtual EspaciosFisico? IdEspaciosFisicosNavigation { get; set; }

    public virtual EstadoOcupanteHorario? IdEstadoOcupanteHorarioNavigation { get; set; }
}
