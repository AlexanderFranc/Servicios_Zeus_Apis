using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoEmpleado
{
    public int IdTipoEmp { get; set; }

    public string? NombreTipoEmp { get; set; }

    public string? DescripcionTipoEmp { get; set; }

    public bool? ActivoTipoEmp { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
