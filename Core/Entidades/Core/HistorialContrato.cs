using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HistorialContrato
{
    public int IdHistorial { get; set; }

    public int? IdContrato { get; set; }

    public string? NumeroContratoHistorial { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? Dedicacion { get; set; }

    public int? TipoContrato { get; set; }

    public int? RelacionContrato { get; set; }

    public int? EstadoContrato { get; set; }

    public virtual Contrato? IdContratoNavigation { get; set; }
}
