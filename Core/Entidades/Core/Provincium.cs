using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Provincium
{
    public int IdProvincia { get; set; }

    public int? IdPais { get; set; }

    public string CodigoProvincia { get; set; } = null!;

    public string? NombreProvincia { get; set; }

    public bool? ActivoProvincia { get; set; }

    public virtual ICollection<Canton> Cantons { get; } = new List<Canton>();

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    public virtual Pai? IdPaisNavigation { get; set; }
}
