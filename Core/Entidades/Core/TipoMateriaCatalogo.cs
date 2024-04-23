using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoMateriaCatalogo
{
    public int IdTipoMateriaCatalogo { get; set; }

    public string? NombreTipoMateriaCatalogo { get; set; }

    public string? DescripcionTipoMateriaCatalogo { get; set; }

    public bool? ActivoTipoMateriaCatalogo { get; set; }

    public virtual ICollection<CatalogoMateria> CatalogoMateria { get; } = new List<CatalogoMateria>();

    public virtual ICollection<Materium> Materia { get; } = new List<Materium>();
}
