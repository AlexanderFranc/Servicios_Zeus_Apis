using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class UnidadOrganizacionCurricular
{
    public int IdUoc { get; set; }

    public string? NombreUoc { get; set; }

    public string? CodigoUoc { get; set; }

    public bool? ActivoUoc { get; set; }

    public string? Color { get; set; }

    public virtual ICollection<Materium> Materia { get; } = new List<Materium>();
}
