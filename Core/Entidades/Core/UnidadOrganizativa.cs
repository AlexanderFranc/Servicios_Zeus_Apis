using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class UnidadOrganizativa
{
    public int IdUo { get; set; }

    public string UnidadOrganizativa1 { get; set; } = null!;

    public string CodigoUo { get; set; } = null!;

    public int? IdFacultad { get; set; }

    public bool? ActivoUo { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
