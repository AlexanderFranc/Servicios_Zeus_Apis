using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConceptosGeneralesDescuento
{
    public int IdConceptosDescuentos { get; set; }

    public string? NombreConceptosDescuentos { get; set; }

    public string? DescripcionConceptosDescuentos { get; set; }

    public string? UsuariocreaConceptosDescuentos { get; set; }

    public string? UsuariomodConceptosDescuentos { get; set; }

    public string? UsuarioelimConceptosDescuentos { get; set; }

    public DateTime? FecharegConceptosDescuentos { get; set; }

    public DateTime? FechamodConceptosDescuentos { get; set; }

    public bool? ActivoConceptosDescuentos { get; set; }
}
