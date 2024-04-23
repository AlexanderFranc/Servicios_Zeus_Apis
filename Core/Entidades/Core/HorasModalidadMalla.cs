using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HorasModalidadMalla
{
    public int IdHorasModalidadMalla { get; set; }

    public bool? ActivoModalidadMalla { get; set; }

    public string? DescripcionModalidadMalla { get; set; }

    public DateTime? HoraFinModalidadMalla { get; set; }

    public DateTime? HoraInicioModalidadMalla { get; set; }

    public string? NombreModalidadMalla { get; set; }
}
