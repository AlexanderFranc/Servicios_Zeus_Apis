using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PermisosCarrera
{
    public int IdPermisosCarrera { get; set; }

    public int? IdCarrera { get; set; }

    public int? IdTipoPermisoCarrera { get; set; }

    public string? NombrePermisosCarrera { get; set; }

    public string? DescripcionPermisosCarrera { get; set; }

    public DateTime? FecahregPermisosCarrera { get; set; }

    public string? PathPermisosCarrera { get; set; }

    public string? UsercreaPermisosCarrera { get; set; }

    public bool? ActivoPermisosCarrera { get; set; }

    public virtual Carrera? IdCarreraNavigation { get; set; }

    public virtual TipoPermisoCarrera? IdTipoPermisoCarreraNavigation { get; set; }
}
