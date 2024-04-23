using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadPe
{
    public int IdModalidadPe { get; set; }

    public string? CodigoModalidadPe { get; set; }

    public string? NombreModalidadPe { get; set; }

    public string? DescripcionModalidadPe { get; set; }

    public bool? ActivoModalidadPe { get; set; }

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();
}
