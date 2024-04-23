using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Actividade
{
    public int IdActividades { get; set; }

    public int? IdDistributivo { get; set; }

    public virtual DistributivoDocente? IdDistributivoNavigation { get; set; }

    public virtual ICollection<TipoActividade> TipoActividades { get; } = new List<TipoActividade>();
}
