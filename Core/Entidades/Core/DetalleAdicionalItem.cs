using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DetalleAdicionalItem
{
    public int IdDetalleAdicionalItem { get; set; }

    public string? LabelDetalleAdicionalItem { get; set; }

    public string? ObservacionDetalleAdicionalItem { get; set; }

    public bool? ActivoDetalleAdicionalItem { get; set; }

    public virtual ICollection<ItemDetalleAdicional> ItemDetalleAdicionals { get; } = new List<ItemDetalleAdicional>();
}
