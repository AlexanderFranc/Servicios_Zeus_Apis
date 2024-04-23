using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Parroquium
{
    public int IdParroquia { get; set; }

    public int? IdCanton { get; set; }

    public string CodigoParroquia { get; set; } = null!;

    public string NombreParroquia { get; set; } = null!;

    public bool? ActivoParroquia { get; set; }

    public virtual ICollection<Campus> Campuses { get; } = new List<Campus>();

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    public virtual Canton? IdCantonNavigation { get; set; }
}
