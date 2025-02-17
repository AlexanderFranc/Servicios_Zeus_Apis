using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Idioma
{
    public int IdIdioma { get; set; }

    public int IdEmp { get; set; }

    public string Idioma1 { get; set; } = null!;

    public string Institucion { get; set; } = null!;

    public string? Nivel { get; set; }

    public DateOnly? FechaEmision { get; set; }

    public bool? Certificacion { get; set; }

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
