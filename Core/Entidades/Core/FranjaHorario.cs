using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class FranjaHorario
{
    public int IdFranjaHorario { get; set; }

    public int? IdEspaciosFisicos { get; set; }

    public int? IdEstadoFranjaHorario { get; set; }

    public DateTime? HorarioiFranjaHorario { get; set; }

    public DateTime? HorariofFranjaHorario { get; set; }

    public string? LunesFranjaHorario { get; set; }

    public string? MartesFranjaHorario { get; set; }

    public string? MiercolesFranjaHorario { get; set; }

    public string? JuevesFranjaHorario { get; set; }

    public string? ViernesFranjaHorario { get; set; }

    public string? SabadoFranjaHorario { get; set; }

    public string? DomingoFranjaHorario { get; set; }

    public string? ObservacionFranjaHorario { get; set; }

    public bool? ActivoFranjaHorario { get; set; }

    public bool? EstadoLunesFranjaHorario { get; set; }

    public bool? EstadoMartesFranjaHorario { get; set; }

    public bool? EstadoMiercolesFranjaHorario { get; set; }

    public bool? EstadoJuevesFranjaHorario { get; set; }

    public bool? EstadoViernesFranjaHorario { get; set; }

    public bool? EstadoSabadoFranjaHorario { get; set; }

    public bool? EstadoDomingoFranjaHorario { get; set; }

    public int? PlanestudioLunesFranjaHorario { get; set; }

    public int? PlanestudioMartesFranjaHorario { get; set; }

    public int? PlanestudioMiercolesFranjaHorario { get; set; }

    public int? PlanestudioJuevesFranjaHorario { get; set; }

    public int? PlanestudioViernesFranjaHorario { get; set; }

    public int? PlanestudioSabadoFranjaHorario { get; set; }

    public int? PlanestudioDomingoFranjaHorario { get; set; }

    public virtual EspaciosFisico? IdEspaciosFisicosNavigation { get; set; }

    public virtual EstadoFranjaHorario? IdEstadoFranjaHorarioNavigation { get; set; }
}
