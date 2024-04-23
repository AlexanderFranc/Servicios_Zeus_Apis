using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoComponente
{
    public int IdEstadoc { get; set; }

    public string? NombreEstadoc { get; set; }

    public string? DescripcionEstadoc { get; set; }

    public string? ObservacionEstadoc { get; set; }

    public bool? ActivoEstadoc { get; set; }

    public virtual ICollection<Componente> Componentes { get; } = new List<Componente>();
}
