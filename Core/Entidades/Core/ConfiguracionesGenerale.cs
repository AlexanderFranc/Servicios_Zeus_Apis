using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ConfiguracionesGenerale
{
    public int IdConfgen { get; set; }

    public int? IdMalla { get; set; }

    public int? IdMateria { get; set; }

    public int? IdNivelEstudio { get; set; }

    public int? IdPlanEstudio { get; set; }

    public int? IdPeriodo { get; set; }

    public int? IdPeriodicidad { get; set; }

    public int? IdTipoPeriodo { get; set; }

    public int? IdModalidad { get; set; }

    public int? IdEstadoPeriodo { get; set; }

    public int? IdModalidadPlanificacion { get; set; }

    public int? IdPeriodicidadPlanificacion { get; set; }

    public int? IdTipoComponente { get; set; }

    public string? Paralelo { get; set; }

    public string? AsistecniasConfgen { get; set; }

    public double? PorcentajeAsistenciasConfgen { get; set; }

    public string? AprobacionConfgen { get; set; }

    public double? PorcentajeAprobacionConfgen { get; set; }

    public string? NotaminConfgen { get; set; }

    public double? PorcentajeNotaminConfgen { get; set; }

    public int? NumParcialesConfgen { get; set; }

    public string? ParcialConfgen { get; set; }

    public double? PorcentajeParcialConfgen { get; set; }

    public string? ExamenFinalConfgen { get; set; }

    public double? PorcentajeExamenFinalConfgen { get; set; }

    public string? NotaFinalConfgen { get; set; }

    public double? PorcentajeNotaFinalConfgen { get; set; }

    public bool? ActivoConfgen { get; set; }

    public virtual ICollection<ConceptoCalificacione> ConceptoCalificaciones { get; } = new List<ConceptoCalificacione>();

    public virtual ICollection<ConceptoMateriaConfiguracion> ConceptoMateriaConfiguracions { get; } = new List<ConceptoMateriaConfiguracion>();
}
