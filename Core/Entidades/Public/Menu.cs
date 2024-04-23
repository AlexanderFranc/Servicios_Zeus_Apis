using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class Menu
{
    public int IdMenu { get; set; }

    public int? MenIdMenu { get; set; }

    public int? IdAplicacion { get; set; }

    public int? IdMenuPadre { get; set; }

    public int? IdAplicaciones { get; set; }

    public string? NombreMenu { get; set; }

    public string? DescripcionMenu { get; set; }

    public string? UrlMenu { get; set; }

    public string? TipoMenu { get; set; }

    public int? OrdenMenu { get; set; }

    public bool? ActivoMenu { get; set; }

    public string? IconoMenu { get; set; }

    public string? IconoposMenu { get; set; }

    public string? LabelMenu { get; set; }

    public DateTime? FechaAperturaMenu { get; set; }

    public DateTime? FechaCierreMenu { get; set; }

    public bool? AperturadoMenu { get; set; }

    public virtual Aplicacion? IdAplicacionNavigation { get; set; }

    public virtual ICollection<MenuPerfil> MenuPerfils { get; } = new List<MenuPerfil>();
}
