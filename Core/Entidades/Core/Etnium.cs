using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Etnium
{
    public int IdEtnia { get; set; }

    public string Etnia { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
