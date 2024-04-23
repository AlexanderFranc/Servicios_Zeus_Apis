using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class Perfil
{
    public int IdPerfil { get; set; }

    public string? NombrePerfil { get; set; }

    public string? DescripcionPerfil { get; set; }

    public bool? ActivoPerfil { get; set; }

    public int? IdAplicacion { get; set; }

    public virtual Aplicacion? IdAplicacionNavigation { get; set; }

    public virtual ICollection<MenuPerfil> MenuPerfils { get; } = new List<MenuPerfil>();

    public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; } = new List<UsuarioPerfil>();
}
