using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoInfraestructura
{
    public int IdTipoInfraestructura { get; set; }

    public string? CodigoTipoInfraestructura { get; set; }

    public string? NombreTipoInfraestructura { get; set; }

    public bool? ActivoTipoInfraestructura { get; set; }

    public virtual ICollection<Infraestructura> Infraestructuras { get; } = new List<Infraestructura>();
}
