using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class UsuarioFa
{
    public int IdFa { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public bool? ActivoFa { get; set; }

    public virtual FactoresAutenticacion IdFaNavigation { get; set; } = null!;

    public virtual Usuario NombreUsuarioNavigation { get; set; } = null!;
}
