using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadPeriodo
{
    public int IdModalidad { get; set; }

    public string? NombreModalidadp { get; set; }

    public string? DescripcionModalidadp { get; set; }

    public bool? ActivoModalidadp { get; set; }

    public virtual ICollection<Periodo> Periodos { get; } = new List<Periodo>();

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();
}
