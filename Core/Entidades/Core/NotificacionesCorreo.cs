using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class NotificacionesCorreo
{
    public int IdNotifCorreo { get; set; }

    public string? CorreoNotifCorreo { get; set; }

    public bool? ActivoNotifCorreo { get; set; }

    public string? ProcesoNotifCorreo { get; set; }
}
