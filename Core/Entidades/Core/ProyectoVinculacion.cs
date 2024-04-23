using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ProyectoVinculacion
{
    public int IdProyVincu { get; set; }

    public int? IdEmp { get; set; }

    public string TituloPVin { get; set; } = null!;

    public int Duracion { get; set; }

    public string? Participantes { get; set; }
}
