using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class SubtipoTitulacion
{
    public int IdSubtipoTitulacion { get; set; }

    public int? IdTipoTitulacion { get; set; }

    public string? NombreSubtipoTitulacion { get; set; }

    public bool? ActivoTipoTitulacion { get; set; }

    public virtual TipoTitulacion? IdTipoTitulacionNavigation { get; set; }

    public virtual ICollection<ModalidadTitulacionPe> ModalidadTitulacionPes { get; } = new List<ModalidadTitulacionPe>();
}
