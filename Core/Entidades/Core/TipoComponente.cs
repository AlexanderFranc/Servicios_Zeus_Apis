using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoComponente
{
    public int IdTipoComponente { get; set; }

    public string? CodigoTipoComponente { get; set; }

    public string? NombreTipoComponente { get; set; }

    public string? DescripcionTipoComponente { get; set; }

    public bool? IncluyeDedicacionDocenteTipoComponente { get; set; }

    public bool? ActivoTipoComponente { get; set; }

    public virtual ICollection<SubtipoComponente> SubtipoComponentes { get; } = new List<SubtipoComponente>();
}
