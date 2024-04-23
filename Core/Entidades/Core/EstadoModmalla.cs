using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoModmalla
{
    public int IdEstadoModmalla { get; set; }

    public string? NombreEstadoModmalla { get; set; }

    public string? DescripcionEstadoModmalla { get; set; }

    public bool? ActivoEstadoModmalla { get; set; }

    public virtual ICollection<ModalidadMalla> ModalidadMallas { get; } = new List<ModalidadMalla>();
}
