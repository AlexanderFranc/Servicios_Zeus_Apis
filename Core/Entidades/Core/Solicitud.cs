using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Solicitud
{
    public int IdSolicitud { get; set; }

    public string TipoSolicitud { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public int IdAsociado { get; set; }

    public string Estado { get; set; } = null!;

    public string Observacion { get; set; } = null!;

    public string Uc { get; set; } = null!;

    public DateTime Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }
}
