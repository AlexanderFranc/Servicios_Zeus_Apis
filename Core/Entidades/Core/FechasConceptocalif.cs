using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class FechasConceptocalif
{
    public int IdFechaConcalif { get; set; }

    public int? IdConceptocalif { get; set; }

    public string? NombreFechaConcalif { get; set; }

    public DateTime? FechainicioConcalif { get; set; }

    public DateTime? FechafinConcalif { get; set; }

    public bool? ActivoConcalif { get; set; }

    public virtual ConceptoCalificacione? IdConceptocalifNavigation { get; set; }
}
