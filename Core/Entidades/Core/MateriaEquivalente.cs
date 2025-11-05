using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class MateriaEquivalente
{
    public int IdMateriaEquivalente { get; set; }

    public int IdMalla { get; set; }

    public int IdMallaEquiv { get; set; }

    public decimal PorcEquiv { get; set; }

    public string? ObservacionesMateriaEquivalente { get; set; }

    public string? PathautorizacionMateriaEquivalente { get; set; }

    public bool? AutorizacionMateriaEquivalente { get; set; }

    public bool? ActivoMateriaEquivalente { get; set; }

    public virtual Malla IdMallaEquivNavigation { get; set; } = null!;

    public virtual Malla IdMallaNavigation { get; set; } = null!;
}
