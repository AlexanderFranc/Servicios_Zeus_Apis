using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Dium
{
    public int IdDia { get; set; }

    public string CodDia { get; set; } = null!;

    public string? NombreDia { get; set; }

    public string? DescripcionDia { get; set; }
}
