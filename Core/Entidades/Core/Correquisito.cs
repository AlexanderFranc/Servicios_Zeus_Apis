using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Correquisito
{
    public int IdCorrequisito { get; set; }

    public int? IdTipoPrecorrequisito { get; set; }

    public int? IdPlanEstudio { get; set; }

    public int? IdTipoAprobacion { get; set; }

    public bool? ActivoMateriaCorrequisito { get; set; }

    public string? PathCorrequisito { get; set; }

    public string? ObservacionCorrequisito { get; set; }

    public virtual PlanEstudio? IdPlanEstudioNavigation { get; set; }

    public virtual TipoAprobacion? IdTipoAprobacionNavigation { get; set; }

    public virtual TipoPrecorequisito? IdTipoPrecorrequisitoNavigation { get; set; }
}
