using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ControlesPeriodo
{
    public int IdControlPeriodo { get; set; }

    public int? IdPeriodo { get; set; }

    public int? IdPeriodicidad { get; set; }

    public int? IdTipoPeriodo { get; set; }

    public int? IdModalidad { get; set; }

    public int? IdEstadoPeriodo { get; set; }

    public string? NombreControlPeriodo { get; set; }

    public DateTime? FechaiControlPeriodo { get; set; }

    public DateTime? FechafControlPeriodo { get; set; }

    public string? VigenteControlPeriodo { get; set; }

    public bool? ActivoControlPeriodo { get; set; }

    public int? IdCarreraControlPeriodo { get; set; }

    public int? IdFacultadControlPeriodo { get; set; }
}
