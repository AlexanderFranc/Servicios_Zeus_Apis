using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CodigoCumplimientoPrerrequisito
{
    public int IdCodigoCumplimientopr { get; set; }

    public string? CodigoCodigoCumplimientopr { get; set; }

    public string? NombreCodigoCumplimientopr { get; set; }

    public string? DescripcionCodigoCumplimientopr { get; set; }

    public bool? ActivoCodigoCumplimientopr { get; set; }

    public virtual ICollection<PrerrequisitosPlanEstudio> PrerrequisitosPlanEstudios { get; } = new List<PrerrequisitosPlanEstudio>();
}
