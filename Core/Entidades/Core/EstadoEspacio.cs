using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoEspacio
{
    public int IdEstadoEspacio { get; set; }

    public string? NombreEstadoEspacio { get; set; }

    public string? DescripcionEstadoEsapcio { get; set; }

    public bool? ActivoEstadoEspacio { get; set; }

    public virtual ICollection<EspaciosFisico> EspaciosFisicos { get; } = new List<EspaciosFisico>();
}
