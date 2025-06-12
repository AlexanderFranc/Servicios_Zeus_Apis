using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Profesor1
{
    public int IdPs { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public int IdPlanificacion { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public decimal Horas { get; set; }

    public string Tipo { get; set; } = null!;

    public bool? Activo { get; set; }

    public string Uc { get; set; } = null!;

    public DateTime Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public virtual Empleado DniProfesorcNavigation { get; set; } = null!;

    public virtual Planificacion IdPlanificacionNavigation { get; set; } = null!;
}
