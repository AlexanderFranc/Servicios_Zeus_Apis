using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoActividade
{
    public int IdTipoActividades { get; set; }

    public int? IdActividades { get; set; }

    public virtual Actividade? IdActividadesNavigation { get; set; }
}
