using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class RelacionFam
{
    public int Id { get; set; }

    public string Relacion { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool? Activo { get; set; }
}
