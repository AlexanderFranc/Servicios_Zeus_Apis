using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Descuento
{
    public int IdDescuento { get; set; }

    public int? IdEstadoDescuento { get; set; }

    public double? ValorDescuento { get; set; }

    public string? MotivoDescuento { get; set; }

    public DateTime? FecharegDescuento { get; set; }

    public DateTime? FechamodDescuento { get; set; }

    public DateTime? FechaelimDescuento { get; set; }

    public string? UsuarioregDescuento { get; set; }

    public string? UsuariomodDescuento { get; set; }

    public string? UsuarioelimDescuento { get; set; }

    public DateTime? FechaiDescuento { get; set; }

    public DateTime? FechafDescuento { get; set; }

    public int? ConceptoGeneralPrecioDescuento { get; set; }

    public bool? ActivoDescuento { get; set; }

    public virtual EstadoDescuento? IdEstadoDescuentoNavigation { get; set; }
}
