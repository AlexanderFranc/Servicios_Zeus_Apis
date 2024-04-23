using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class Aplicacion
{
    public int IdAplicacion { get; set; }

    public string? NombreAplicacion { get; set; }

    public string? DescripcionAplicacion { get; set; }

    public string? UrlAplicacion { get; set; }

    public string? IconoAplicacion { get; set; }

    public string? BannerAplicacion { get; set; }

    public bool? ActivoAplicacion { get; set; }

    public virtual ICollection<MenuPerfil> MenuPerfils { get; } = new List<MenuPerfil>();

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();

    public virtual ICollection<Perfil> Perfils { get; } = new List<Perfil>();

    public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; } = new List<UsuarioPerfil>();
}
