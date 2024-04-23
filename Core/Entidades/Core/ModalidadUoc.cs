using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadUoc
{
    public int IdModalidadUoc { get; set; }

    public string? NombreModalidadUoc { get; set; }

    public bool? ActivoModalidadUoc { get; set; }

    public virtual ICollection<UnidadOrganizacionCurricular> UnidadOrganizacionCurriculars { get; } = new List<UnidadOrganizacionCurricular>();
}
