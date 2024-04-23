using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string? NombreCategoria { get; set; }

    public string? DescripcionCategoria { get; set; }

    public bool? ActivoCategoria { get; set; }

    public virtual ICollection<InstitucionEducativa> InstitucionEducativas { get; } = new List<InstitucionEducativa>();
}
