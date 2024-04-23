using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class NivelAcademico
{
    public int IdNivelAcademico { get; set; }

    public string NivelAcademico1 { get; set; } = null!;

    public int? TipoUnidadEducativa { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<InfoAcademica> InfoAcademicas { get; } = new List<InfoAcademica>();
}
