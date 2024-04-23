using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoModalidadTitulacion
{
    public int IdTipoModalidadTitulacion { get; set; }

    public string? NombreTipoModalidadTitulacion { get; set; }

    public bool? ActivoTipoModalidadTitulacion { get; set; }

    public virtual ICollection<SubtipoModalidadTitulacion> SubtipoModalidadTitulacions { get; } = new List<SubtipoModalidadTitulacion>();
}
