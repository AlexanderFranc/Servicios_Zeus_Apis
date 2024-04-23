using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoAutoridadfacultad
{
    public int IdTipoautoridadf { get; set; }

    public string? NombreTipoautoridadf { get; set; }

    public bool? ActivoTipoautoridadf { get; set; }

    public virtual ICollection<AutoridadesFacultad> AutoridadesFacultads { get; } = new List<AutoridadesFacultad>();
}
