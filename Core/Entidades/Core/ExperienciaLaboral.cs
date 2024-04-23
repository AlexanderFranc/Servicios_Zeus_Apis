using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ExperienciaLaboral
{
    public int IdExperienciaLaboral { get; set; }

    public int? IdEmp { get; set; }

    public string? Institucion { get; set; } = null!;

    public string? Cargo { get; set; } = null!;

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool? Actualmente { get; set; }

    public decimal? Sueldo { get; set; }

    public string? RazonSalida { get; set; } = null!;

    public string? Contacto { get; set; } = null!;

    public string? CargoContacto { get; set; }

    public string? TelefonoContacto { get; set; } = null!;

    public string? Certificado { get; set; }

    public virtual Empleado? IdEmpNavigation { get; set; }
}
