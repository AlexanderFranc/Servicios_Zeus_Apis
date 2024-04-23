using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class FranjaHorarium
{
    public int IdFh { get; set; }

    public int? IdPlanEstudio { get; set; }

    public int? SemestreIni { get; set; }

    public int? SemestreFin { get; set; }

    public int? DiaIni { get; set; }

    public int? DiaFin { get; set; }

    public DateTime? HoraIni { get; set; }

    public DateTime? HoraFin { get; set; }

    public bool? ActivoFh { get; set; }

    public virtual PlanEstudio? IdPlanEstudioNavigation { get; set; }
}
