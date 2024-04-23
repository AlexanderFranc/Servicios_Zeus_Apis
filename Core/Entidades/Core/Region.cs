using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Region
{
    public int IdRegion { get; set; }

    public int? IdPais { get; set; }

    public string? NombreRegion { get; set; }

    public bool? ActivoRegion { get; set; }

    public virtual Pai? IdPaisNavigation { get; set; }
}
