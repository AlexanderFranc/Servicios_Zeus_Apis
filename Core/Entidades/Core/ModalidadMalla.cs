using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ModalidadMalla
{
    public int IdModalidadMalla { get; set; }

    public int? IdPeriodo { get; set; }

    public int? IdEstadoModmalla { get; set; }

    public int? IdMalla { get; set; }

    public int? IdModalidad { get; set; }

    public string? NombreModalidadMalla { get; set; }

    public string? DescripcionModalidadMalla { get; set; }

    public bool? ActivoModalidadMalla { get; set; }

    public virtual ICollection<HorasModalidadMalla> HorasModalidadMallas { get; } = new List<HorasModalidadMalla>();

    public virtual EstadoModmalla? IdEstadoModmallaNavigation { get; set; }

    public virtual Malla? IdMallaNavigation { get; set; }

    public virtual Modalidad? IdModalidadNavigation { get; set; }

    public virtual Periodo? IdPeriodoNavigation { get; set; }

    public virtual ICollection<NivelEstudio> NivelEstudios { get; } = new List<NivelEstudio>();
}
