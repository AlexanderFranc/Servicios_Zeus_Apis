using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HorarioFechaTemp
{
    public int IdPlanTemp { get; set; }

    public DateTime Fecha { get; set; }

    public TimeOnly HoraIni { get; set; }

    public TimeOnly HoraFin { get; set; }

    public int? OrdenFecha { get; set; }

    public bool Activo { get; set; }

    public int IdEspaciosFisicos { get; set; }

    public virtual PlanificacionTemp IdPlanTempNavigation { get; set; } = null!;
}
