using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DetalleItem
{
    public int IdDetalleItem { get; set; }

    public int? IdItem { get; set; }

    public string? NombreDetalleItem { get; set; }

    public string? DescripcionDetalleItem { get; set; }

    public string? DimensionesDetalleItem { get; set; }

    public double? LargoDetalleItem { get; set; }

    public double? AnchoDetalleItem { get; set; }

    public double? ProfundidadDetalleItem { get; set; }

    public double? AreaDetalleItem { get; set; }

    public string? ObservacionesDetalleItem { get; set; }

    public bool? ActivoDetalleItem { get; set; }

    public virtual Item? IdItemNavigation { get; set; }
}
