using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ActAcademicasAutoridadCarrera
{
    public int IdAaAutoridadCarrera { get; set; }

    public int? IdAutoridadc { get; set; }

    public string? NombreAaAutoridadCarrera { get; set; }

    public string? DescripcionAaAutoridadCarrera { get; set; }

    public bool? ActivoAaAutoridadCarrera { get; set; }

    public virtual AutoridadesCarrera? IdAutoridadcNavigation { get; set; }
}
