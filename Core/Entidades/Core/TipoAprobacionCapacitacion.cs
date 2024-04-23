using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoAprobacionCapacitacion
{
    public int IdTipoAprobacion { get; set; }

    public string? TipoAprobacion { get; set; }

    public string? CodigoTipoAprobacion { get; set; }

    public bool? ActivoTipoAprobacion { get; set; }
}
