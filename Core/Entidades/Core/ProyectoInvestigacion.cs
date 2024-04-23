using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ProyectoInvestigacion
{
    public int IdProyInves { get; set; }

    public int? IdEmp { get; set; }

    public string TituloPInv { get; set; } = null!;

    public int Duracion { get; set; }

    public string? Participantes { get; set; }
}
