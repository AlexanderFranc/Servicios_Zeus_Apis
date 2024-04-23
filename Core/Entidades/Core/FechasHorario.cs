using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class FechasHorario
{
    public int IdFechaHorario { get; set; }

    public int? IdEspaciosFisicos { get; set; }

    public int? IdEstadoFechasHorario { get; set; }

    public DateTime? FechaiFechaHorario { get; set; }

    public DateTime? FechafFechaHorario { get; set; }

    public bool? ActivoFechaHorario { get; set; }

    public string? ActividadFechaHorario { get; set; }

    public string? DescripcionFechaHorario { get; set; }

    public int? IdPlanestudioFechasHorario { get; set; }

    public virtual EspaciosFisico? IdEspaciosFisicosNavigation { get; set; }

    public virtual EstadoFechasHorario? IdEstadoFechasHorarioNavigation { get; set; }
}
