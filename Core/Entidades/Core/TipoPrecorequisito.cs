using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPrecorequisito
{
    public int IdTipoPrecorrequisito { get; set; }

    public string? NombreTipoPrecorrequisito { get; set; }

    public bool? ActivoTipoPrecorrequisito { get; set; }

    public string? ModoTipoPrecorrequisito { get; set; }

    public bool? ArchivoTipoPrecorrequisito { get; set; }

    public virtual ICollection<Correquisito> Correquisitos { get; } = new List<Correquisito>();

    public virtual ICollection<Prerrequisito> Prerrequisitos { get; } = new List<Prerrequisito>();
}
