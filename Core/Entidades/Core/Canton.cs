using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Canton
{
    public int IdCanton { get; set; }

    public int? IdProvincia { get; set; }

    public string CodigoCanton { get; set; } = null!;

    public string NombreCanton { get; set; } = null!;

    public bool? ActivoCanton { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    public virtual Provincium? IdProvinciaNavigation { get; set; }

    public virtual ICollection<Parroquium> Parroquia { get; } = new List<Parroquium>();
}
