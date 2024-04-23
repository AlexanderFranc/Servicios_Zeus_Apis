using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class NivelEstudio
{
    public int IdNivelEstudio { get; set; }

    public string? CodigoNivelEstudio { get; set; }

    public string? NombreNivelEstudio { get; set; }

    public string? DescripcionNivelEstudio { get; set; }

    public bool? ActivoNivelEstudio { get; set; }

    public virtual ICollection<Malla> Mallas { get; } = new List<Malla>();

    public virtual ICollection<SubnivelEstudio> SubnivelEstudios { get; } = new List<SubnivelEstudio>();
}
