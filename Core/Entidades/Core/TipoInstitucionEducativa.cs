using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoInstitucionEducativa
{
    public int IdTipoInstitucionEducativa { get; set; }

    public string? NombreTipoInstitucionEducativa { get; set; }

    public string? DescripcionTipoInstitucionEducativa { get; set; }

    public bool? ActivoTipoInstitucionEducativa { get; set; }

    public virtual ICollection<InstitucionEducativa> InstitucionEducativas { get; } = new List<InstitucionEducativa>();
}
