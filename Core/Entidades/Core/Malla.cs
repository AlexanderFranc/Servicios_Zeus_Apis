using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Malla
{
    public int IdMalla { get; set; }

    public int IdMateria { get; set; }

    public int IdNivelEstudio { get; set; }

    public int IdPlanEstudio { get; set; }

    public int? OrdenMalla { get; set; }

    public DateTime? FecharegMalla { get; set; }

    public string? UsuarioregMalla { get; set; }

    public string? UsuarioactMalla { get; set; }

    public string? UsuarioelimMalla { get; set; }

    public bool? ActivoMalla { get; set; }

    public string? ObservacionMalla { get; set; }

    public virtual ICollection<ConceptoPrecio> ConceptoPrecios { get; } = new List<ConceptoPrecio>();

    public virtual Materium IdMateriaNavigation { get; set; } = null!;

    public virtual NivelEstudio IdNivelEstudioNavigation { get; set; } = null!;

    public virtual PlanEstudio IdPlanEstudioNavigation { get; set; } = null!;

    public virtual ICollection<MateriaEquivalente> MateriaEquivalenteIdMallaEquivNavigations { get; } = new List<MateriaEquivalente>();

    public virtual ICollection<MateriaEquivalente> MateriaEquivalenteIdMallaNavigations { get; } = new List<MateriaEquivalente>();

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();

    public virtual ICollection<Prerrequisito> Prerrequisitos { get; } = new List<Prerrequisito>();
}
