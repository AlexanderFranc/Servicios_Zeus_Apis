using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HorarioLog
{
    public DateTime Fecha { get; set; }

    public string TipoModificacion { get; set; } = null!;

    public int IdPlanificacion { get; set; }

    public int IdDia { get; set; }

    public TimeOnly HoraIni { get; set; }

    public TimeOnly HoraFin { get; set; }
}
