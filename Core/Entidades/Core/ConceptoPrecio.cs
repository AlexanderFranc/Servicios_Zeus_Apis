using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConceptoPrecio
{
    public int IdPrecio { get; set; }

    public int? IdMalla { get; set; }

    public string? NombrePrecio { get; set; }

    public string? DescripcionPrecio { get; set; }

    public string? ObservacionPrecio { get; set; }

    public double? ValorPrecio { get; set; }

    public DateTime? FechaiPrecio { get; set; }

    public DateTime? FechafPrecio { get; set; }

    public DateTime? FecharegPrecio { get; set; }

    public string? UsuarioregPrecio { get; set; }

    public string? UsuariomodPrecio { get; set; }

    public bool? ActivoPrecio { get; set; }

    public virtual ICollection<HistorialPrecio> HistorialPrecios { get; } = new List<HistorialPrecio>();

    public virtual Malla? IdMallaNavigation { get; set; }
}
