using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoAprobacionMateriaPrincipal
{
    public int IdTipoAprobacionMateriaPrincipal { get; set; }

    public int? IdMateriap { get; set; }

    public string? NombreTipoAprobacionMateriaPrincipal { get; set; }

    public string? CodigoTipoAprobacionMateriaPrincipal { get; set; }

    public string? ObservacionesTipoAprobacionMateriaPrincipal { get; set; }

    public bool? ActivoTipoAprobacionMateriaPrincipal { get; set; }

    public virtual MateriaPrincipal? IdMateriapNavigation { get; set; }
}
