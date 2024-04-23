using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DuracionComponente
{
    public int IdDuracionComponente { get; set; }

    public string? NombreDuracionComponente { get; set; }

    public bool? ActivoDuracionComponente { get; set; }

    public virtual ICollection<Componente> Componentes { get; } = new List<Componente>();
}
