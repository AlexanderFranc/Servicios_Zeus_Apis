using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CampoAmplio
{
    public int IdCa { get; set; }

    public string CodigoCa { get; set; } = null!;

    public string CampoAmplio1 { get; set; } = null!;

    public virtual ICollection<EmpleadoTempNuevo> EmpleadoTempNuevos { get; } = new List<EmpleadoTempNuevo>();
}
