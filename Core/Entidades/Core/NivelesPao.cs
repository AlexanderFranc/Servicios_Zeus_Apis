using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class NivelesPao
{
    public int IdNivelespao { get; set; }

    public int? IdMalla { get; set; }

    public string? NombreNivelesPao { get; set; }

    public string? DescripcionNivelesPao { get; set; }

    public bool? ActivoNivelesPao { get; set; }

    public virtual Malla? IdMallaNavigation { get; set; }
}
