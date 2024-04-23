using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoDetalle
{
    public int IdEstadoDetalle { get; set; }

    public string? NombreEstadoDetalle { get; set; }

    public string? DescripcionEstadoDetalle { get; set; }

    public bool? ActivoEstadoDetalle { get; set; }

    public virtual ICollection<DetalleItem> DetalleItems { get; } = new List<DetalleItem>();
}
