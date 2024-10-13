using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PlanificacionTemp
{
    public int IdPlanTemp { get; set; }

    public int IdSolicitud { get; set; }

    public int IdPlanificacion { get; set; }

    public int IdMalla { get; set; }

    public int IdPeriodo { get; set; }

    public int IdModalidadPlanificacion { get; set; }

    public int IdPeriodicidadPlanificacion { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public int IdTipoComponente { get; set; }

    public string Paralelo { get; set; } = null!;

    public int IdEspaciosFisicos { get; set; }

    public int Cupo { get; set; }

    public bool Activo { get; set; }

    public string? Tipod { get; set; }

    public virtual Planificacion IdPlanificacionNavigation { get; set; } = null!;

    public virtual Solicitud IdSolicitudNavigation { get; set; } = null!;
}
