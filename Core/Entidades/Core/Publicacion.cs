using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Publicacion
{
    public int IdPublicacion { get; set; }

    public int? IdEmp { get; set; }

    public int? IdTipoPublicacion { get; set; }

    public string Titulo { get; set; } = null!;

    public string? IsbnIssn { get; set; }

    public string? RegPropiedadIntelectual { get; set; }

    public string? Url { get; set; }

    public int Ano { get; set; }

    public string BaseDatos { get; set; } = null!;

    public string? Certificado { get; set; }

    public virtual Empleado? IdEmpNavigation { get; set; }
}
