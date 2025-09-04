using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Materium
{
    public int IdMateria { get; set; }

    public int? IdUoc { get; set; }

    public int? IdTipoAprobacion { get; set; }

    public string? CodigoMateria { get; set; }

    public string? NombreMateria { get; set; }

    public double? CreditosMateria { get; set; }

    public int? HorasSemestralesMateria { get; set; }

    public int? CuposMatriculaMateria { get; set; }

    public string? CampoUnescoMateria { get; set; }

    public bool? ActivoMateria { get; set; }

    public int IdTipoMateriaCatalogo { get; set; }

    public int? RefCred { get; set; }

    public int? TipoMat { get; set; }

    public virtual ICollection<Componente> Componentes { get; } = new List<Componente>();

    public virtual TipoAprobacion? IdTipoAprobacionNavigation { get; set; }

    public virtual TipoMateriaCatalogo IdTipoMateriaCatalogoNavigation { get; set; } = null!;

    public virtual UnidadOrganizacionCurricular? IdUocNavigation { get; set; }

    public virtual ICollection<Malla> Mallas { get; } = new List<Malla>();
}
