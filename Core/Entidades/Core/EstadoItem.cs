using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoItem
{
    public int IdEstadoItem { get; set; }

    public string? NombreEstadoItem { get; set; }

    public string? DescripcionEstadoItem { get; set; }

    public bool? ActivoEstadoItem { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
