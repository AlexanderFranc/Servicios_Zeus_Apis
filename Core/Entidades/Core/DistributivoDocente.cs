using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DistributivoDocente
{
    public int IdDistributivo { get; set; }

    public int? IdEmp { get; set; }

    public int? IdContratoDistributivo { get; set; }

    public virtual ICollection<Actividade> Actividades { get; } = new List<Actividade>();

    public virtual Empleado? IdEmpNavigation { get; set; }
}
