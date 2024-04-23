using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoActividad
{
    public int IdTipoActividad { get; set; }

    public string TipoActividad1 { get; set; } = null!;

    public bool Activo { get; set; }
}
