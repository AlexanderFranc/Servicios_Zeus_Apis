using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PeriodicidadMateriaPrincipal
{
    public int IdPeriodicidadMateriaPrincipal { get; set; }

    public int? IdMateriap { get; set; }

    public string? NombrePeriodicidadMateriaPrincipal { get; set; }

    public string? CodigoPeriodicidadMateriaPrincipal { get; set; }

    public string? DescripcionPeriodicidadMateriaPrincipal { get; set; }

    public bool? ActivoPeriodicidadMateriaPrincipal { get; set; }

    public virtual MateriaPrincipal? IdMateriapNavigation { get; set; }
}
