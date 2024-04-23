using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoConceptocalif
{
    public int IdTipoConceptocalif { get; set; }

    public string? NombreTipoConceptocalif { get; set; }

    public string? DescripcionTipoConceptocalif { get; set; }

    public bool? ActivoTipoConceptocalif { get; set; }

    public virtual ICollection<ConceptoCalificacione> ConceptoCalificaciones { get; } = new List<ConceptoCalificacione>();
}
