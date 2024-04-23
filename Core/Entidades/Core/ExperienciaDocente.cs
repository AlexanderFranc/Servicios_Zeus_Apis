using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ExperienciaDocente
{
    public int IdExperienciaDocente { get; set; }

    public int IdEmp { get; set; }

    public int? IdUnidadEducativa { get; set; }

    public bool InstitucionSuperior { get; set; }

    public string? Institucion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public bool Titular { get; set; }

    public string? CertificadoLaboral { get; set; }

    public string? CertificadoTitularidad { get; set; }

    public virtual Empleado? IdEmpNavigation { get; set; }
}
