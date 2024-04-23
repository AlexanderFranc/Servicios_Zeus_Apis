using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class RequisitosEgresamiento
{
    public int IdReqEgresamiento { get; set; }

    public int? IdMalla { get; set; }

    public int? IdTipoReqEgresamiento { get; set; }

    public string? NombreReqEgresamiento { get; set; }

    public string? CodigoReqEgresamiento { get; set; }

    public string? DescripcionReqEgresamiento { get; set; }

    public string? ObservacionReqEgresamiento { get; set; }

    public bool? ActivoReqEgresamiento { get; set; }

    public virtual Malla? IdMallaNavigation { get; set; }

    public virtual TipoRequisitoEgresamiento? IdTipoReqEgresamientoNavigation { get; set; }
}
