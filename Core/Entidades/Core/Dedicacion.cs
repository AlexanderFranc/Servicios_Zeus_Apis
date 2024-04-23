using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Dedicacion
{
    public int IdDedicacion { get; set; }

    public string? NombreDedicacion { get; set; }

    public double? HorasDedicacion { get; set; }

    public bool? ActivoDedicacion { get; set; }

    public virtual ICollection<TipoContrato> TipoContratos { get; } = new List<TipoContrato>();
}
