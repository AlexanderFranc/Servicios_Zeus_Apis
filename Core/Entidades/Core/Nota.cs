using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Nota
{
    public int IdNotac { get; set; }

    public string? DniProfesorc { get; set; }

    public double? PorcentajeNotac { get; set; }

    public double? ValorNotac { get; set; }

    public bool? EstadoNotac { get; set; }

    public virtual Profesor? DniProfesorcNavigation { get; set; }
}
