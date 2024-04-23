using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class RefreshToken
{
    public DateTime Expira { get; set; }

    public string Token { get; set; } = null!;

    public string? NombreUsuario { get; set; }

    public long Id { get; set; }

    public virtual Usuario? NombreUsuarioNavigation { get; set; }
}
