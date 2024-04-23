using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoCorrequisito
{
    public int IdTipoCorrequisito { get; set; }

    public string? NombreTipoCorrequisito { get; set; }

    public bool? ActivoTipoCorrequisito { get; set; }

    public string? ModoTipoCorrequisito { get; set; }

    public bool? ArchivoTipoCorrequisito { get; set; }

    public virtual ICollection<Correquisito> Correquisitos { get; } = new List<Correquisito>();
}
