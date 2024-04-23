using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class NivelInfraestructura
{
    public int IdNivelInfraestructura { get; set; }

    public int? IdInfraestructura { get; set; }

    public string? CodigoNivelInfraestructura { get; set; }

    public string? NombreNivelInfraestructura { get; set; }

    public bool? ActivoNivelInfraestructura { get; set; }

    public virtual ICollection<EspaciosFisico> EspaciosFisicos { get; } = new List<EspaciosFisico>();

    public virtual Infraestructura? IdInfraestructuraNavigation { get; set; }

    public virtual ICollection<PlanoNivel> PlanoNivels { get; } = new List<PlanoNivel>();
}
