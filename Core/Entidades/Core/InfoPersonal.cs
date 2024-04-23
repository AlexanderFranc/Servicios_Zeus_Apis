using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InfoPersonal
{
    public int IdInforPersonal { get; set; }

    public int? IdEmp { get; set; }

    public virtual Empleado? IdEmpNavigation { get; set; }
}
