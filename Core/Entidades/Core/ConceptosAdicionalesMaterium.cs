using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConceptosAdicionalesMaterium
{
    public int IdConceptosAdicionalesMateria { get; set; }

    public string? NombreConceptosAdicionalesMateria { get; set; }

    public string? DescripcionConceptosAdicionalesMateria { get; set; }

    public bool? ActivoConceptosAdicionalesMateria { get; set; }

    public virtual ICollection<ConceptoMateriaConfiguracion> ConceptoMateriaConfiguracions { get; } = new List<ConceptoMateriaConfiguracion>();
}
