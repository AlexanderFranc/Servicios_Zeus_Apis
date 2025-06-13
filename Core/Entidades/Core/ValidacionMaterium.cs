using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ValidacionMaterium
{
    public int IdValidacionMateria { get; set; }

    public string? CodigoPeriodo { get; set; }

    public string? CodigoPlanEstudioMalla { get; set; }

    public int? IdModalidad { get; set; }

    public string? CodigoMateria { get; set; }

    public bool? Activo { get; set; }

    public virtual ModalidadPe? IdModalidadNavigation { get; set; }
}
