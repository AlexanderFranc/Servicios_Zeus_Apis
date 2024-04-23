using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InstitucionEducativa
{
    public int IdInstitucionEducativa { get; set; }

    public int? IdTipoInstitucionEducativa { get; set; }

    public int? IdCategoria { get; set; }

    public string? CodigoInstitucionEducativa { get; set; }

    public string? NombreInstitucionEducativa { get; set; }

    public string? CodautorizacionInstitucionEducativa { get; set; }

    public string? PathauitorizacionInstitucionEducativa { get; set; }

    public string? UsercreaInstitucionEducativa { get; set; }

    public string? UseractInstitucionEducativa { get; set; }

    public string? UsereliInstitucionEducativa { get; set; }

    public DateTime? FechacreaInstitucionEducativa { get; set; }

    public DateTime? FechaactInstitucionEducativa { get; set; }

    public DateTime? FechaeliInstitucionEducativa { get; set; }

    public bool? ActivoInstitucionEducativa { get; set; }

    public virtual ICollection<Acreditacione> Acreditaciones { get; } = new List<Acreditacione>();

    public virtual ICollection<AutoridadesInstitucionEducativa> AutoridadesInstitucionEducativas { get; } = new List<AutoridadesInstitucionEducativa>();

    public virtual ICollection<Convenio> Convenios { get; } = new List<Convenio>();

    public virtual ICollection<DesignacionesInstitucionEducativa> DesignacionesInstitucionEducativas { get; } = new List<DesignacionesInstitucionEducativa>();

    public virtual Categorium? IdCategoriaNavigation { get; set; }

    public virtual TipoInstitucionEducativa? IdTipoInstitucionEducativaNavigation { get; set; }

    public virtual ICollection<Premio> Premios { get; } = new List<Premio>();

    public virtual ICollection<SedeInstitucion> SedeInstitucions { get; } = new List<SedeInstitucion>();
}
