using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoUoc
{
    public int IdTipoUoc { get; set; }

    public string? NombreTipoUoc { get; set; }

    public bool? ActivoTipoUoc { get; set; }

    public virtual ICollection<UnidadOrganizacionCurricular> UnidadOrganizacionCurriculars { get; } = new List<UnidadOrganizacionCurricular>();
}
