using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoDescuento
{
    public int IdEstadoDescuento { get; set; }

    public string? NombreEstadoDescuento { get; set; }

    public string? DescripcionEstadoDescuento { get; set; }

    public bool? ActivoEstadoDescuento { get; set; }

    public virtual ICollection<Descuento> Descuentos { get; } = new List<Descuento>();
}
