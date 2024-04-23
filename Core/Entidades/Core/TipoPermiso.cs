using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPermiso
{
    public int IdTipoPermiso { get; set; }

    public string? NombreTipoPermiso { get; set; }

    public string? DescriocionTipoPermiso { get; set; }

    public bool? ActivoTipoPermiso { get; set; }

    public virtual ICollection<Permiso> Permisos { get; } = new List<Permiso>();
}
