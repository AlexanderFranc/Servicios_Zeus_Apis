using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoEmpleado
{
    public int IdEstadoEmp { get; set; }

    public string? NombreEstadoEmp { get; set; }

    public bool? ActivoEstadoEmp { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
