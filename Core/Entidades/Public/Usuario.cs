using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class Usuario
{
    public string NombreUsuario { get; set; } = null!;

    public string? DniUsuario { get; set; }

    public string? TipoDniUsuario { get; set; }

    public string? Password { get; set; }

    public string? EmailPersonalUsuario { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaCreacionUsuario { get; set; }

    public DateTime? FechaActualizacionUsuario { get; set; }

    public bool? ActivoUsuario { get; set; }

    public string? FotoUsuario { get; set; }

    public string? NombresUsuario { get; set; }

    public string? ApellidosUsuario { get; set; }

    public bool? FaUsuario { get; set; }

    public string? Tipo2faUsuario { get; set; }

    public int? IntentosUsuario { get; set; }

    public virtual ICollection<LogsAcceso> LogsAccesos { get; } = new List<LogsAcceso>();

    public virtual ICollection<RefreshToken> RefreshTokens { get; } = new List<RefreshToken>();

    public virtual ICollection<UsuarioFa> UsuarioFas { get; } = new List<UsuarioFa>();

    public virtual ICollection<UsuarioPerfil> UsuarioPerfils { get; } = new List<UsuarioPerfil>();
}
