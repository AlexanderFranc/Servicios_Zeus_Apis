using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Permiso
{
    public int IdPermisos { get; set; }

    public int? IdTipoPermiso { get; set; }

    public int? IdCampus { get; set; }

    public string? NombrePermisos { get; set; }

    public string? DescripcionPermisos { get; set; }

    public DateTime? FecharegPermisos { get; set; }

    public string? PathPermisos { get; set; }

    public string? UsercreaPermisos { get; set; }

    public bool? ActivoPermisos { get; set; }

    public virtual Campus? IdCampusNavigation { get; set; }

    public virtual TipoPermiso? IdTipoPermisoNavigation { get; set; }
}
