using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DuracionPeriodo
{
    public int IdDuracionPeriodo { get; set; }

    public string? NombreDuracionPeriodo { get; set; }

    public bool? ActivoDuracionPeriodo { get; set; }

    public virtual ICollection<Periodo> Periodos { get; } = new List<Periodo>();
}
