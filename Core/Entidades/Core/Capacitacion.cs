using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Capacitacion
{
    public int IdCapacitacion { get; set; }

    public int IdEmp { get; set; }

    public int? IdTipoAprobacion { get; set; }

    public int? IdTipoActividad { get; set; }

    public string Institucion { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? Duracion { get; set; }

    public string? Certificado { get; set; }

    public virtual Empleado? IdEmpNavigation { get; set; }
}
