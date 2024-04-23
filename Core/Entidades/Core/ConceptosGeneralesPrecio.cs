using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConceptosGeneralesPrecio
{
    public int IdConceptoGeneral { get; set; }

    public string? NombreConceptoGeneral { get; set; }

    public string? DescripcionConceptoGeneral { get; set; }

    public string? UsuariocreaConceptoGeneral { get; set; }

    public string? UsuariomodConceptoGeneral { get; set; }

    public string? UsuarioelimConceptoGeneral { get; set; }

    public DateTime? FecahregConceptoGeneral { get; set; }

    public DateTime? FechamodConceptoGeneral { get; set; }

    public bool? ActivoConceptoGeneral { get; set; }
}
