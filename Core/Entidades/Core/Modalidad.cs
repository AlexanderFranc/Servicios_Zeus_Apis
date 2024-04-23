using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Modalidad
{
    public int IdModalidad { get; set; }

    public string? CodigoModalidad { get; set; }

    public string? NombreModalidad { get; set; }

    public string? DescripcionModalidad { get; set; }

    public bool? ActivoModalidad { get; set; }

    public virtual ICollection<ModalidadMalla> ModalidadMallas { get; } = new List<ModalidadMalla>();
}
