using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DetalleModalidadTitulacion
{
    public int IdDetalleMt { get; set; }

    public string? CodigoDetalleMt { get; set; }

    public string? ObservacionesDetalleMt { get; set; }

    public string? NombreDetalleMt { get; set; }

    public bool? ActivoDetalleMt { get; set; }

    public int? IdModalidadTitulacion { get; set; }

    public int? IdSubtipoModalidadTitulacion { get; set; }

    public virtual ModalidadTitulacion? IdModalidadTitulacionNavigation { get; set; }

    public virtual SubtipoModalidadTitulacion? IdSubtipoModalidadTitulacionNavigation { get; set; }
}
