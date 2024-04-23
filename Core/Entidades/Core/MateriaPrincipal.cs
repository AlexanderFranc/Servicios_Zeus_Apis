using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class MateriaPrincipal
{
    public int IdMateriap { get; set; }

    public int? IdUoc { get; set; }

    public int? IdTipoMateriaPrincipal { get; set; }

    public int? IdNivelEstudio { get; set; }

    public string? CodigoMateriap { get; set; }

    public string? NombreMateriap { get; set; }

    public double? CreditosMateriap { get; set; }

    public int? HorasSemestralesMateriap { get; set; }

    public int? CuposMatriculaMateriap { get; set; }

    public int? MateriaCompartidaMateriap { get; set; }

    public int? MateriaEquivalenteMateriap { get; set; }

    public string? CampoUnescoMateriap { get; set; }

    public bool? ActivoMateriap { get; set; }

    public virtual ICollection<ConfiguracionesGenerale> ConfiguracionesGenerales { get; } = new List<ConfiguracionesGenerale>();

    public virtual ICollection<DuracionMateriaPrincipal> DuracionMateriaPrincipals { get; } = new List<DuracionMateriaPrincipal>();

    public virtual NivelEstudio? IdNivelEstudioNavigation { get; set; }

    public virtual TipoMateriaPrincipal? IdTipoMateriaPrincipalNavigation { get; set; }

    public virtual UnidadOrganizacionCurricular? IdUocNavigation { get; set; }

    public virtual ICollection<PeriodicidadMateriaPrincipal> PeriodicidadMateriaPrincipals { get; } = new List<PeriodicidadMateriaPrincipal>();

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();

    public virtual ICollection<TipoAprobacionMateriaPrincipal> TipoAprobacionMateriaPrincipals { get; } = new List<TipoAprobacionMateriaPrincipal>();
}
