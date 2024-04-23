using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPlanEstudio
{
    public int IdTipoPe { get; set; }

    public string? NombreTipoPe { get; set; }

    public string? ObservacionTipoPe { get; set; }

    public bool? ActivoTipoPe { get; set; }

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();
}
