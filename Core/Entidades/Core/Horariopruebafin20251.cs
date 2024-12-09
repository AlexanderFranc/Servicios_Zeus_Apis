using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Horariopruebafin20251
{
    public int IdPlanificacion { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public string? CodigoMateria { get; set; }

    public string? CodigoEspaciosFisicos { get; set; }

    public string Paralelo { get; set; } = null!;

    public string? NombreDia { get; set; }

    public int IdDia { get; set; }

    public TimeOnly HoraIni { get; set; }

    public TimeOnly HoraFin { get; set; }

    public string? CodigoCarrera { get; set; }

    public string? CodigoPlanEstudioMalla { get; set; }

    public int IdTipoComponente { get; set; }

    public long? Fila { get; set; }

    public string IdentificacionEmp { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Componente { get; set; }

    public string? Nommateria { get; set; }
}
