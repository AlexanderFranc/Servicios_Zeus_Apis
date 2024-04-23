using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HistorialPrecio
{
    public int IdHprecios { get; set; }

    public int? IdPrecio { get; set; }

    public string? NombreHprecios { get; set; }

    public string? DescripcionHprecios { get; set; }

    public string? ObservacionHprecios { get; set; }

    public double? ValorHprecios { get; set; }

    public DateTime? FechaiHprecios { get; set; }

    public DateTime? FechafHprecios { get; set; }

    public DateTime? FecharegHprecios { get; set; }

    public string? UsuarioregHprecios { get; set; }

    public string? UsuariomodHprecios { get; set; }

    public string? MotivocambioHprecios { get; set; }

    public bool? ActivoHprecios { get; set; }

    public virtual ConceptoPrecio? IdPrecioNavigation { get; set; }
}
