using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoTitulacion
{
    public int IdTipoTitulacion { get; set; }

    public string? NombreTipoTitulacion { get; set; }

    public bool? ActivoTipoTitulacion { get; set; }

    public virtual ICollection<SubtipoTitulacion> SubtipoTitulacions { get; } = new List<SubtipoTitulacion>();
}
