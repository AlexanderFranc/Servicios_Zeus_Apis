using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ItemDetalleAdicional
{
    public int IdItem { get; set; }

    public int IdDetalleAdicionalItem { get; set; }

    public string? ValorDetalleItem { get; set; }

    public virtual DetalleAdicionalItem IdDetalleAdicionalItemNavigation { get; set; } = null!;

    public virtual Item IdItemNavigation { get; set; } = null!;
}
