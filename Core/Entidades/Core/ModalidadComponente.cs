using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadComponente
{
    public int IdModalidadComponente { get; set; }

    public string? NombreModalidadComponente { get; set; }

    public bool? ActivoModalidadComponente { get; set; }

    public virtual ICollection<Componente> Componentes { get; } = new List<Componente>();
}
