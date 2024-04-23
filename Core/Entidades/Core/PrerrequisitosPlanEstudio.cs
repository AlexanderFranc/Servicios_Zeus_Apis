using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PrerrequisitosPlanEstudio
{
    public int IdPpestudios { get; set; }

    public int? IdCodigoCumplimientopr { get; set; }

    public string? CodigoMateriaPlanEstudio { get; set; }

    public int? NivelPlanEstudio { get; set; }

    public int? CarreraPlanEstudio { get; set; }

    public int? MallaPlanEstudio { get; set; }

    public string? ParaleloPlanEstudio { get; set; }

    public int? IdTipoPpe { get; set; }

    public string? NombrePpestudios { get; set; }

    public bool? CumpleMateria { get; set; }

    public string? DescripcionPpestudios { get; set; }

    public bool? ActivoMateriaPpestudios { get; set; }

    public string? PathPrerrequsito { get; set; }

    public virtual CodigoCumplimientoPrerrequisito? IdCodigoCumplimientoprNavigation { get; set; }

    public virtual TipoPrerrequisitoPlanEstudio? IdTipoPpeNavigation { get; set; }

    public virtual PlanEstudio? PlanEstudio { get; set; }
}
