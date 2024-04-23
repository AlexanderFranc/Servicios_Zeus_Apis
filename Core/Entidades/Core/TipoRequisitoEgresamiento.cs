using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoRequisitoEgresamiento
{
    public int IdTipoReqEgresamiento { get; set; }

    public string? NombreTipoReqEgresamiento { get; set; }

    public bool? ActivoTipoReqEgresamiento { get; set; }

    public virtual ICollection<RequisitosEgresamientoPe> RequisitosEgresamientoPes { get; } = new List<RequisitosEgresamientoPe>();
}
