using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoAutoridadCarrera
{
    public int IdTipoAutoridadc { get; set; }

    public string? NombreTipoAutoridadc { get; set; }

    public bool? ActivoTipoAutoridadc { get; set; }

    public virtual ICollection<AutoridadesCarrera> AutoridadesCarreras { get; } = new List<AutoridadesCarrera>();
}
