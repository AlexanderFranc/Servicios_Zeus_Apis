using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Orden
{
    public int IdOrden { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public bool Estado { get; set; }
}
