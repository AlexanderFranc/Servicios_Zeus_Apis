using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoDiscapacidad
{
    public int IdTipoDiscapacidad { get; set; }

    public string TipoDiscapacidad1 { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
