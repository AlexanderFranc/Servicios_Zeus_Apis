using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CarnetConadi
{
    public int IdCarnetConadis { get; set; }

    public int? IdTipoDiscapacidad { get; set; }

    public int? IdEmp { get; set; }

    public string NumeroCarnet { get; set; } = null!;

    public decimal Porcentaje { get; set; }

    public string? Carnet { get; set; }
}
