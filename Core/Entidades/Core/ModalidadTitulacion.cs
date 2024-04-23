using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadTitulacion
{
    public int IdModalidadTitulacion { get; set; }

    public int? IdTipoModalidadTitulacion { get; set; }

    public int? IdMalla { get; set; }

    public int? IdDetalleMt { get; set; }

    public string? NombreModalidadTitulacion { get; set; }

    public string? CodigoModalidadTitulacion { get; set; }

    public string? ObservacionModalidadTitulacion { get; set; }

    public bool? ActivoModalidadTitulacion { get; set; }

    public virtual ICollection<DetalleModalidadTitulacion> DetalleModalidadTitulacions { get; } = new List<DetalleModalidadTitulacion>();

    public virtual Malla? IdMallaNavigation { get; set; }
}
