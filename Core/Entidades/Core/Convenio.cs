using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Convenio
{
    public int IdConvenios { get; set; }

    public int? IdTipoConvenio { get; set; }

    public int? IdInstitucionEducativa { get; set; }

    public string? NombreConvenios { get; set; }

    public string? EmpresaConvenios { get; set; }

    public DateTime? FechainicioConvenios { get; set; }

    public DateTime? FechafinConvenios { get; set; }

    public string? PathConvenios { get; set; }

    public bool? ActivoConvenios { get; set; }

    public virtual InstitucionEducativa? IdInstitucionEducativaNavigation { get; set; }

    public virtual TipoConvenio? IdTipoConvenioNavigation { get; set; }
}
