using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PlanEstudio
{
    public int IdPlanEstudio { get; set; }

    public int? IdEstadoPe { get; set; }

    public int? IdCarrera { get; set; }

    public int? IdModalidadPe { get; set; }

    public string? CodigoPlanEstudioMalla { get; set; }

    public string? NumerodecretoCesMalla { get; set; }

    public string? PathdecretoCesMalla { get; set; }

    public int? DuracionSemestresMalla { get; set; }

    public int? PeriodicidadMalla { get; set; }

    public int? CupoCesMalla { get; set; }

    public DateTime? FechaAprobacionMalla { get; set; }

    public DateTime? FechaVigenciaMalla { get; set; }

    public string? SemestreInicioMalla { get; set; }

    public string? SemestreFinMalla { get; set; }

    public string? PathresolucionactivaMalla { get; set; }

    public string? PathresolucioncierreMalla { get; set; }

    public string? ObservacionesMalla { get; set; }

    public bool? ActivoMalla { get; set; }

    public int? IdNivelEstudio { get; set; }

    public virtual ICollection<Componente> Componentes { get; } = new List<Componente>();

    public virtual ICollection<Correquisito> Correquisitos { get; } = new List<Correquisito>();

    public virtual ICollection<FranjaHorarium> FranjaHoraria { get; } = new List<FranjaHorarium>();

    public virtual Carrera? IdCarreraNavigation { get; set; }

    public virtual EstadoPe? IdEstadoPeNavigation { get; set; }

    public virtual ModalidadPe? IdModalidadPeNavigation { get; set; }

    public virtual ICollection<Malla> Mallas { get; } = new List<Malla>();

    public virtual ICollection<ModalidadTitulacionPe> ModalidadTitulacionPes { get; } = new List<ModalidadTitulacionPe>();

    public virtual Periodicidad? PeriodicidadMallaNavigation { get; set; }

    public virtual ICollection<RequisitosEgresamientoPe> RequisitosEgresamientoPes { get; } = new List<RequisitosEgresamientoPe>();
}
