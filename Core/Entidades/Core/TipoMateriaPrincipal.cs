using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoMateriaPrincipal
{
    public int IdTipoMateriaPrincipal { get; set; }

    public string? NombreTipoMateriaPrincipal { get; set; }

    public bool? ActivoTipoMateriaPrincipal { get; set; }

    public bool? DedicaciondocenteTipoMateriaPrincipal { get; set; }

    public virtual ICollection<MateriaPrincipal> MateriaPrincipals { get; } = new List<MateriaPrincipal>();
}
