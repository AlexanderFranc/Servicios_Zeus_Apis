using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DetalleOcupanteHorario
{
    public int IdDetalleOcupanteHorario { get; set; }

    public int? IdOcupanteHorario { get; set; }

    public DateTime? HoraiDetalleOcupanteHorario { get; set; }

    public DateTime? HorafDetalleOcupanteHorario { get; set; }

    public string? ObservacionesDetalleOcupanteHorario { get; set; }

    public string? DiasDetalleOcupanteHorario { get; set; }

    public bool? ActivoDetalleOcupanteHorario { get; set; }

    public virtual OcupanteHorario? IdOcupanteHorarioNavigation { get; set; }
}
