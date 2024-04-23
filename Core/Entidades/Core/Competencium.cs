using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Competencium
{
    public int IdCompetencia { get; set; }

    public int? IdEmp { get; set; }

    public string Competencia { get; set; } = null!;

    public int Nivel { get; set; }
}
