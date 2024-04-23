using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DesignacionesCarrera
{
    public int IdDesignacionesCarreras { get; set; }

    public int? IdCarrera { get; set; }

    public string? MotivoDesignacionesCarreras { get; set; }

    public string? ObservacionDesignacionesCarreras { get; set; }

    public string? DniusuarioDesignacionesCarreras { get; set; }

    public int? IdAutoridadentranteDesignacionesCarreras { get; set; }

    public int? IdAutoridadsalienteDesignacionesCarreras { get; set; }

    public string? PatharchivoDesignacionesCarreras { get; set; }

    public DateTime? FecharegDesignacionesCarreras { get; set; }

    public DateTime? FechaactDesignacionesCarreras { get; set; }

    public DateTime? FecahdelDesignacionesCarreras { get; set; }

    public DateTime? FechainicioDesignacionesCarreras { get; set; }

    public DateTime? FechafinDesignacionesCarreras { get; set; }

    public bool? ActivoDesignacionesCarreras { get; set; }

    public virtual Carrera? IdCarreraNavigation { get; set; }
}
