using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CruceHorario
{
    public string? Cedula { get; set; }

    public string? Docente { get; set; }

    public string? CodigoCarrera { get; set; }

    public string? Carrera { get; set; }

    public string? Malla { get; set; }

    public string? Codigo { get; set; }

    public string? Materia { get; set; }

    public string? Paralelo { get; set; }

    public string? Aula { get; set; }

    public string? Dia { get; set; }

    public string? HoraIni { get; set; }

    public string? HoraFin { get; set; }

    public int? IdPlanificacion { get; set; }
}
