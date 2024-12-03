using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CampoEspecifico
{
    public int IdCe { get; set; }

    public int? IdCa { get; set; }

    public string CodigoCe { get; set; } = null!;

    public string CampoEspecifico1 { get; set; } = null!;

    public virtual ICollection<EmpleadoTempNuevo> EmpleadoTempNuevos { get; } = new List<EmpleadoTempNuevo>();
}
