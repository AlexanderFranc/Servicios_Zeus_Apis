using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPublicacion
{
    public int IdTipoPublicacion { get; set; }

    public string TipoPublicacion1 { get; set; } = null!;

    public bool Activo { get; set; }
}
