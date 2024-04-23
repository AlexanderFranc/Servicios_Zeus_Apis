using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string? TipoDocumento1 { get; set; }

    public bool? ActivoTipoDocumento { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
