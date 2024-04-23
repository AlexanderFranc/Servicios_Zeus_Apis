using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadTitulacionPe
{
    public int IdModalidadTitulacionPe { get; set; }

    public int? IdPlanEstudio { get; set; }

    public int? IdSubtipoTitulacion { get; set; }

    public string? NombreModalidadTitulacionPe { get; set; }

    public string? CodigoModalidadTitulacionPe { get; set; }

    public string? ObservacionModalidadTitulacionPe { get; set; }

    public bool? ActivoModalidadTitulacionPe { get; set; }

    public virtual PlanEstudio? IdPlanEstudioNavigation { get; set; }

    public virtual SubtipoTitulacion? IdSubtipoTitulacionNavigation { get; set; }
}
