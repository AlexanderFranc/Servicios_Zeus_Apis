using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TitularidadEmp
{
    public int IdTitularidad { get; set; }

    public int IdDedicacion { get; set; }

    public string Titularidad { get; set; } = null!;

    public bool Activo { get; set; }
}
