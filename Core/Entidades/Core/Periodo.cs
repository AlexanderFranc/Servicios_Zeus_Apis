using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Periodo
{
    public int IdPeriodo { get; set; }

    public int IdTipoPeriodo { get; set; }

    public int IdModalidad { get; set; }

    public int IdEstadoPeriodo { get; set; }

    public string? CodigoPeriodo { get; set; }

    public string? CodigoNumeroPeriodo { get; set; }

    public string? CodigoTextoPeriodo { get; set; }

    public string? DescripcionPeriodo { get; set; }

    public DateTime? FechaInicioPeriodo { get; set; }

    public DateTime? FechaFinPeriodo { get; set; }

    public DateTime? FechaRegistroPeriodo { get; set; }

    public DateTime? FechaActualizaPeriodo { get; set; }

    public bool? ActivoPeriodo { get; set; }

    public bool? ActivoPeriodoSilabo { get; set; }

    public int? AnoPeriodo { get; set; }

    public bool? ActivoPeriodoPlanificacion { get; set; }

    public bool? ActivoPeriodoVinculacion { get; set; }

    public bool? ActivoPeriodoCambParal { get; set; }

    public virtual EstadoPeriodo IdEstadoPeriodoNavigation { get; set; } = null!;

    public virtual ModalidadPeriodo IdModalidadNavigation { get; set; } = null!;

    public virtual TipoPeriodo IdTipoPeriodoNavigation { get; set; } = null!;

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();
}
