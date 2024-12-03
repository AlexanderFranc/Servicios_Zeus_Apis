using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class FormaPagoEmp
{
    public int IdFpago { get; set; }

    public string Fpago { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<EmpleadoTempNuevo> EmpleadoTempNuevos { get; } = new List<EmpleadoTempNuevo>();
}
