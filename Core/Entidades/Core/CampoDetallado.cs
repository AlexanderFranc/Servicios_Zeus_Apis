using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CampoDetallado
{
    public int IdCd { get; set; }

    public int? IdCe { get; set; }

    public string CodigoCd { get; set; } = null!;

    public string CampoDetallado1 { get; set; } = null!;
}
