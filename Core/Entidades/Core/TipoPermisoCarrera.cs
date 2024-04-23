using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPermisoCarrera
{
    public int IdTipoPermisoCarrera { get; set; }

    public string? NombreTipoPermisoCarrera { get; set; }

    public string? DescripcionTipoPermisoCarrera { get; set; }

    public bool? ActivoTipoPermisoCarrera { get; set; }

    public virtual ICollection<PermisosCarrera> PermisosCarreras { get; } = new List<PermisosCarrera>();
}
