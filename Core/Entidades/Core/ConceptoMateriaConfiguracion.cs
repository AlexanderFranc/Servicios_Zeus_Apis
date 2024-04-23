using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConceptoMateriaConfiguracion
{
    public int IdConceptosAdicionalesMateria { get; set; }

    public int IdConfgen { get; set; }

    public bool? ActivoConceptoAdicionalMateria { get; set; }

    public virtual ConceptosAdicionalesMaterium IdConceptosAdicionalesMateriaNavigation { get; set; } = null!;

    public virtual ConfiguracionesGenerale IdConfgenNavigation { get; set; } = null!;
}
