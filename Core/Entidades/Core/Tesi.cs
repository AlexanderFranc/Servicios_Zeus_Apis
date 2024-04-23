using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Tesi
{
    public int IdTesis { get; set; }

    public int? IdEmp { get; set; }

    public string Institucion { get; set; } = null!;

    public int TipoTesis { get; set; }

    public int Coodirector { get; set; }

    public string Tema { get; set; } = null!;

    public string? Año { get; set; }
}
