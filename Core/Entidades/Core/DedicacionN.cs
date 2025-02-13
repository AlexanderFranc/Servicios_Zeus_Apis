using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DedicacionN
{
    public int IdDedicacion { get; set; }

    public string Dedicacion { get; set; } = null!;

    public string? DescDedicacion { get; set; }
}
