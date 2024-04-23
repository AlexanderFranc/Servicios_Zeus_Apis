using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class MateriaCompartidum
{
    public int IdMateriaCompartida { get; set; }

    public string? CodigoMateriaCompartida { get; set; }

    public string? NombreMateriaCompartida { get; set; }

    public string? DescripcionMateriaCompartida { get; set; }

    public string? ObservacionesMateriaCompartida { get; set; }

    public int? CarreraMateriaCompartida { get; set; }

    public int? PlanEstudiosMateriaCompartida { get; set; }

    public bool? ActivoMateriaCompartida { get; set; }
}
