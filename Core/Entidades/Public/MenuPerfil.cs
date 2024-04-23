using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class MenuPerfil
{
    public int Id { get; set; }

    public int? IdMenu { get; set; }

    public int? IdAplicacion { get; set; }

    public int? IdPerfil { get; set; }

    public string? PermisosAutorizacion { get; set; }

    public virtual Aplicacion? IdAplicacionNavigation { get; set; }

    public virtual Menu? IdMenuNavigation { get; set; }

    public virtual Perfil? IdPerfilNavigation { get; set; }
}
