using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Planificacion
{
    public int IdMalla { get; set; }

    public int IdPeriodo { get; set; }

    public int IdModalidadPlanificacion { get; set; }

    public int IdPeriodicidadPlanificacion { get; set; }

    public string DniProfesorc { get; set; } = null!;

    public int IdTipoComponente { get; set; }

    public string Paralelo { get; set; } = null!;

    public int IdEspaciosFisicos { get; set; }

    public int? Cupo { get; set; }

    public int IdPlanificacion { get; set; }

    public bool? Activo { get; set; }

    public string? Uc { get; set; }

    public DateTime? Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public virtual Profesor DniProfesorcNavigation { get; set; } = null!;

    public virtual EspaciosFisico IdEspaciosFisicosNavigation { get; set; } = null!;

    public virtual Malla IdMallaNavigation { get; set; } = null!;

    public virtual ModalidadPeriodo IdModalidadPlanificacionNavigation { get; set; } = null!;

    public virtual Periodicidad IdPeriodicidadPlanificacionNavigation { get; set; } = null!;

    public virtual Periodo IdPeriodoNavigation { get; set; } = null!;
}
