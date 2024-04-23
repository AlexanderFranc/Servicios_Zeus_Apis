using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoCarrera
{
    public int IdEstadoCarrera { get; set; }

    public string? NombreEstadoCarrera { get; set; }

    public bool? ActivoEstadoCarrera { get; set; }

    public virtual ICollection<Carrera> Carreras { get; } = new List<Carrera>();
}
