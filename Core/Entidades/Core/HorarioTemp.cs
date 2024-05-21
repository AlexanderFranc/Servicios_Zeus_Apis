using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HorarioTemp
{
    public int IdPlanTemp { get; set; }

    public int IdDia { get; set; }

    public TimeOnly HoraIni { get; set; }

    public TimeOnly HoraFin { get; set; }

    public bool Activo { get; set; }

    public virtual Dium IdDiaNavigation { get; set; } = null!;

    public virtual PlanificacionTemp IdPlanTempNavigation { get; set; } = null!;
}
