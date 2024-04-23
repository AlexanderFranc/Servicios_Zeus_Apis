using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class SubnivelEstudio
{
    public int IdSubnivelEstudio { get; set; }

    public int IdNivelEstudio { get; set; }

    public string CodigoSubnivelEstudio { get; set; } = null!;

    public string NombreSubnivelEstudio { get; set; } = null!;

    public string? DescripcionSubnivelEstudio { get; set; }

    public bool ActivoSubnivelEstudio { get; set; }

    public virtual NivelEstudio IdNivelEstudioNavigation { get; set; } = null!;
}
