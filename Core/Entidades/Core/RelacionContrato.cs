using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class RelacionContrato
{
    public int IdRelacion { get; set; }

    public int? IdTipoContrato { get; set; }

    public string? NombreRelacion { get; set; }

    public string? DescripcionRelacion { get; set; }

    public bool? ActivoRelacion { get; set; }

    public virtual TipoContrato? IdTipoContratoNavigation { get; set; }
}
