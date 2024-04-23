using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class SubtipoComponente
{
    public int IdSubtipoComponente { get; set; }

    public int IdTipoComponente { get; set; }

    public string? CodigoSubtipoComponente { get; set; }

    public string? NombreSubtipoComponente { get; set; }

    public string? DescripcionSubtipoComponente { get; set; }

    public bool? IncluyeDedicacionDocenteSubtipoComponente { get; set; }

    public bool? ActivoSubtipoComponente { get; set; }

    public virtual ICollection<Componente> Componentes { get; } = new List<Componente>();

    public virtual TipoComponente IdTipoComponenteNavigation { get; set; } = null!;
}
