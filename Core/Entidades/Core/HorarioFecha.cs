using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HorarioFecha
{
    public int? IdPlanificacion { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeOnly? HoraIni { get; set; }

    public TimeOnly? HoraFin { get; set; }

    public int? OrdenFecha { get; set; }
}
