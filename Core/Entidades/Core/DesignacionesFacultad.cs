using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DesignacionesFacultad
{
    public int IdDesignacionesFacultad { get; set; }

    public int? IdFacultad { get; set; }

    public string? MotivoDesignacionesFacultad { get; set; }

    public string? ObservacionDesignacionesFacultad { get; set; }

    public string? DniusuarioDesignacionesFacultad { get; set; }

    public int? IdAutoridadentranteDesignacionesFacultad { get; set; }

    public int? IdAutoridadsalienteDesignacionesFacultad { get; set; }

    public string? PatharchivoDesignacionesFacultad { get; set; }

    public DateTime? FecharegDesignacionesFacultad { get; set; }

    public DateTime? FechaactDesignacionesFacultad { get; set; }

    public DateTime? FechadelDesignacionesFacultad { get; set; }

    public DateTime? FechainicioDesignacionesFacultad { get; set; }

    public DateTime? FechafinDesignacionesFacultad { get; set; }

    public bool? ActivoDesignacionesFacultad { get; set; }

    public virtual Facultad? IdFacultadNavigation { get; set; }
}
