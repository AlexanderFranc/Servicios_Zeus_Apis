using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoPrerrequisitoPlanEstudio
{
    public int IdTipoPpe { get; set; }

    public string? NombreTipoPpe { get; set; }

    public bool? ActivoTipoPpe { get; set; }

    public string? ModoTipoPrerrequisito { get; set; }

    public bool? ArchivoTipoPrerrequisito { get; set; }

    public bool? ArchivoTipoPpe { get; set; }

    public string? ModoTipoPpe { get; set; }

    public virtual ICollection<PrerrequisitosPlanEstudio> PrerrequisitosPlanEstudios { get; } = new List<PrerrequisitosPlanEstudio>();
}
