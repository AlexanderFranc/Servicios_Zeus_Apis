using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Horario
{
    public int IdPlanificacion { get; set; }

    public int IdDia { get; set; }

    public TimeOnly HoraIni { get; set; }

    public TimeOnly HoraFin { get; set; }

    public virtual Dium IdDiaNavigation { get; set; } = null!;

    public virtual Planificacion IdPlanificacionNavigation { get; set; } = null!;
}
