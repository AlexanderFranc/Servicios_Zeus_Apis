using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ExperienciaDocente
{
    public int IdExperienciaDocente { get; set; }

    public int IdEmp { get; set; }

    public int? IdUnidadEducativa { get; set; }

    public bool InstitucionSuperior { get; set; }

    public string Institucion { get; set; } = null!;

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public bool? Titular { get; set; }

    public string? CertificadoLaboral { get; set; }

    public string? CertificadoTitularidad { get; set; }

    public string? Uc { get; set; }

    public DateTime? Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public string? UAprueba { get; set; }

    public DateTime? FAprueba { get; set; }

    public bool? AprobadoTh { get; set; }

    public virtual Empleado IdEmpNavigation { get; set; } = null!;
}
