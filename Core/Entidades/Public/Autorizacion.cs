using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class Autorizacion
{
    public int IdAutorizacion { get; set; }

    public int? IdPerfil { get; set; }

    public int? IdMenu { get; set; }

    public int? IdMenus { get; set; }

    public int? IdPerfiles { get; set; }

    public string? PermisosAutorizacion { get; set; }

    public bool? ActivoAutorizacion { get; set; }

    public virtual Menu? IdMenuNavigation { get; set; }

    public virtual Perfil? IdPerfilNavigation { get; set; }
}
