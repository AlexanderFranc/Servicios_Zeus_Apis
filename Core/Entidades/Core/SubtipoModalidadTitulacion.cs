using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class SubtipoModalidadTitulacion
{
    public int IdSubtipoModalidadTitulacion { get; set; }

    public bool? ActivoModalidadTitulacion { get; set; }

    public string? CodigoModalidadTitulacion { get; set; }

    public string? NombreSubtipoModalidadTitulacion { get; set; }

    public string? ObservacionModalidadTitulacion { get; set; }

    public int? IdTipoModalidadTitulacion { get; set; }

    public virtual ICollection<DetalleModalidadTitulacion> DetalleModalidadTitulacions { get; } = new List<DetalleModalidadTitulacion>();

    public virtual TipoModalidadTitulacion? IdTipoModalidadTitulacionNavigation { get; set; }
}
