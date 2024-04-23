using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EstadoRequisito
{
    public int IdEstadoRequisitos { get; set; }

    public string? NombreEstadoRequisito { get; set; }

    public bool? ActivoEstadoRequisito { get; set; }

    public virtual ICollection<GestionDocumental> GestionDocumentals { get; } = new List<GestionDocumental>();
}
