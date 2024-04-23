using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InfoExperiencium
{
    public int IdInfoExperiencia { get; set; }

    public int? IdEmp { get; set; }

    public virtual Empleado? IdEmpNavigation { get; set; }
}
