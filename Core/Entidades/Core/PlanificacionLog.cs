using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PlanificacionLog
{
    public DateTime Fecha { get; set; }

    public string TipoModificacion { get; set; } = null!;

    public int IdPlanificacion { get; set; }

    public int IdMalla { get; set; }

    public int IdPeriodo { get; set; }

    public int IdModalidadPlanificacion { get; set; }

    public int IdPeriodicidadPlanificacion { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public int IdTipoComponente { get; set; }

    public string Paralelo { get; set; } = null!;

    public int IdEspaciosFisicos { get; set; }

    public int Cupo { get; set; }
}
