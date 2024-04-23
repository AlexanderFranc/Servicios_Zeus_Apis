using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class UnidadEducativa
{
    public int IdUnidadEducativa { get; set; }

    public int? TipoUnidadEducativa { get; set; }

    public string? CodigoUnidadEducativa { get; set; }

    public string? NombreUnidadEducativa { get; set; }

    public bool? ActivoUnidadEducativa { get; set; }
}
