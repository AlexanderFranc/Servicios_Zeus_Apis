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

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public int? Duracion { get; set; }

    public string? Certificado { get; set; }

    public string? Uc { get; set; }

    public DateTime? Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public string? UAprueba { get; set; }

    public DateTime? FAprueba { get; set; }

    public bool? AprobadoTh { get; set; }

    public virtual Empleado IdEmpNavigation { get; set; } = null!;
}
