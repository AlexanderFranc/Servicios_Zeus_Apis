using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoAutoridadInstitucionEducativa
{
    public int IdTipoAie { get; set; }

    public string? NombreTipoAie { get; set; }

    public string? DescripcionTipoAie { get; set; }

    public DateTime? FecharegTipoAie { get; set; }

    public DateTime? FechaiTipoAie { get; set; }

    public DateTime? FechafTipoAie { get; set; }

    public bool? ActivoTipoAie { get; set; }

    public virtual ICollection<AutoridadesInstitucionEducativa> AutoridadesInstitucionEducativas { get; } = new List<AutoridadesInstitucionEducativa>();
}
