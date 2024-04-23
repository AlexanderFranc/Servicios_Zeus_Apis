using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PlanoNivel
{
    public int IdPlanoNivel { get; set; }

    public int? IdNivelInfraestructura { get; set; }

    public string? CodigoPlanoNivel { get; set; }

    public string? NombrePlanoNivel { get; set; }

    public string? PathPlanoNivel { get; set; }

    public bool? ActivoPlanoNivel { get; set; }

    public virtual NivelInfraestructura? IdNivelInfraestructuraNavigation { get; set; }
}
