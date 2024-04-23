using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPeriodo
{
    public int IdTipoPeriodo { get; set; }

    public string? NombreTipoPeriodo { get; set; }

    public bool? ActivoTipoPeriodo { get; set; }

    public virtual ICollection<Periodo> Periodos { get; } = new List<Periodo>();
}
