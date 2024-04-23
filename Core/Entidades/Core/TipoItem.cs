using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoItem
{
    public int IdTipoItem { get; set; }

    public string? NombreTipoItem { get; set; }

    public string? DescripcionTipoItem { get; set; }

    public string? CodigoFusionInventoryItem { get; set; }

    public bool? ActivoTipoItem { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
