using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoContratoN
{
    public int IdTipoContrato { get; set; }

    public string TipoContrato { get; set; } = null!;

    public string? DescTipoContrato { get; set; }
}
