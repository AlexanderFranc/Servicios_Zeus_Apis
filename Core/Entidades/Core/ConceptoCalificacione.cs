using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConceptoCalificacione
{
    public int IdConceptocalif { get; set; }

    public int? IdConfgen { get; set; }

    public int? IdTipoConceptocalif { get; set; }

    public string? NombreConceptocalif { get; set; }

    public double? ValorConceptocalif { get; set; }

    public double? PorcentajeConceptocalif { get; set; }

    public string? SiglaConceptocalif { get; set; }

    public bool? ActivoConceptocalif { get; set; }

    public virtual ICollection<FechasConceptocalif> FechasConceptocalifs { get; } = new List<FechasConceptocalif>();

    public virtual ConfiguracionesGenerale? IdConfgenNavigation { get; set; }

    public virtual TipoConceptocalif? IdTipoConceptocalifNavigation { get; set; }
}
