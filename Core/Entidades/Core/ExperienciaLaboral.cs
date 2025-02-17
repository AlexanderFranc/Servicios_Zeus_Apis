using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ExperienciaLaboral
{
    public int IdExperienciaLaboral { get; set; }

    public int IdEmp { get; set; }

    public string Institucion { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public bool? Actualmente { get; set; }

    public decimal? Sueldo { get; set; }

    public string? RazonSalida { get; set; }

    public string? Contacto { get; set; }

    public string? CargoContacto { get; set; }

    public string? TelefonoContacto { get; set; }

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
