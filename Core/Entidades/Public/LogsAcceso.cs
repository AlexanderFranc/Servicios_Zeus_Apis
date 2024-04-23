using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class LogsAcceso
{
    public int IdLogAcceso { get; set; }

    public int? IdAplicaciones { get; set; }

    public int? IdUsuarios { get; set; }

    public int? IdPerfiles { get; set; }

    public DateTime? FechaLogAcceso { get; set; }

    public string? IpLogAcceso { get; set; }

    public string? MacLogAcceso { get; set; }

    public string? NavegadorLogAcceso { get; set; }

    public int? IntentosLogAcceso { get; set; }

    public int? IntentosFallidosLogAcceso { get; set; }

    public bool? CambioPasswordLogAcceso { get; set; }

    public string? UrlLogAcceso { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public virtual Usuario NombreUsuarioNavigation { get; set; } = null!;
}
