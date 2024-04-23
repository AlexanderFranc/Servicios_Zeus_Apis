using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class RequisitosEgresamientoPe
{
    public int IdReqEgresamientoPe { get; set; }

    public int? IdPlanEstudio { get; set; }

    public int? IdTipoReqEgresamiento { get; set; }

    public string? NombreReqEgresamientoPe { get; set; }

    public string? CodigoReqEgresamientoPe { get; set; }

    public string? DescripcionReqEgresamientoPe { get; set; }

    public string? ObservacionReqEgresamientoPe { get; set; }

    public bool? ActivoReqEgresamientoPe { get; set; }

    public virtual PlanEstudio? IdPlanEstudioNavigation { get; set; }

    public virtual TipoRequisitoEgresamiento? IdTipoReqEgresamientoNavigation { get; set; }
}
