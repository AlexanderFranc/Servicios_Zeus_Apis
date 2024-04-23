using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoContrato
{
    public int IdEstadoContrato { get; set; }

    public string? NombreEstadoContrato { get; set; }

    public bool? ActivoEstadoContrato { get; set; }

    public virtual ICollection<Contrato> Contratos { get; } = new List<Contrato>();
}
