using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoConvenio
{
    public int IdTipoConvenio { get; set; }

    public string? NombreTipoConvenio { get; set; }

    public string? DescripcionTipoConvenio { get; set; }

    public bool? ActivoTipoConvenio { get; set; }

    public virtual ICollection<Convenio> Convenios { get; } = new List<Convenio>();
}
