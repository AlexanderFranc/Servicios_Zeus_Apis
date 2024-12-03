using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoSolicitud
{
    public int IdEstado { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<EmpleadoTempNuevo> EmpleadoTempNuevos { get; } = new List<EmpleadoTempNuevo>();

    public virtual ICollection<Solicitud> Solicituds { get; } = new List<Solicitud>();
}
