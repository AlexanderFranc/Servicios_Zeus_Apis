using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DuracionUoc
{
    public int IdDuracionUoc { get; set; }

    public string? NombreDuracionUoc { get; set; }

    public bool? ActivoDuracionUoc { get; set; }

    public virtual ICollection<UnidadOrganizacionCurricular> UnidadOrganizacionCurriculars { get; } = new List<UnidadOrganizacionCurricular>();
}
