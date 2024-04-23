using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DesignacionesInstitucionEducativa
{
    public int IdDesignacionesIe { get; set; }

    public int? IdInstitucionEducativa { get; set; }

    public string? MotivoDesignacionesIe { get; set; }

    public string? ObservacionDesignacionesIe { get; set; }

    public string? DniusuarioDesignacionesIe { get; set; }

    public int? IdAutoridadieentranteDesignacionesIe { get; set; }

    public int? IdAutoridadiesalienteDesignacionesIe { get; set; }

    public string? PatharchivoDesignacionesIe { get; set; }

    public DateTime? FecharegDesignacionesIe { get; set; }

    public DateTime? FechaactDesignacionesIe { get; set; }

    public DateTime? FecahdelDesignacionesIe { get; set; }

    public DateTime? FechainicioDesignacionesIe { get; set; }

    public DateTime? FecahfinDesignacionesIe { get; set; }

    public bool? ActivoDesignacionesIe { get; set; }

    public virtual InstitucionEducativa? IdInstitucionEducativaNavigation { get; set; }
}
