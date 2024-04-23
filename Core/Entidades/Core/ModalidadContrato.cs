using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadContrato
{
    public int IdModalidadContrato { get; set; }

    public string? NombreModalidadContrato { get; set; }

    public string? DescripcionModalidadContrato { get; set; }

    public bool? ActivoModalidadContrato { get; set; }

    public virtual ICollection<Contrato> Contratos { get; } = new List<Contrato>();
}
