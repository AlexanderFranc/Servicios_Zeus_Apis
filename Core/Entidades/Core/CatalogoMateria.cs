using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CatalogoMateria
{
    public string CodigoMateriac { get; set; } = null!;

    public int? IdTipoMateriaCatalogo { get; set; }

    public string? NombreMateriac { get; set; }

    public double? CreditosMateriac { get; set; }

    public double? HorasSemestralesMateriac { get; set; }

    public int? CuposMateriac { get; set; }

    public string? UnescoMateriac { get; set; }

    public bool? ActivoMateriac { get; set; }

    public virtual ICollection<ComponenteCatalogo> ComponenteCatalogos { get; } = new List<ComponenteCatalogo>();

    public virtual TipoMateriaCatalogo? IdTipoMateriaCatalogoNavigation { get; set; }
}
