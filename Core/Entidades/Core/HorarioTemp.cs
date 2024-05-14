using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HorarioTemp
{
    public int IdPlanificacion { get; set; }

    public int IdDia { get; set; }

    public TimeOnly HoraIni { get; set; }

    public TimeOnly HoraFin { get; set; }
}
