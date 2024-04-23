using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Infraestructura
{
    public int IdInfraestructura { get; set; }

    public int? IdCampus { get; set; }

    public int? IdTipoInfraestructura { get; set; }

    public string? CodigoInfraestructura { get; set; }

    public string? NombreInfraestructura { get; set; }

    public string? ReferenciaInfraestructura { get; set; }

    public bool? ActivoInfraestructura { get; set; }

    public virtual Campus? IdCampusNavigation { get; set; }

    public virtual TipoInfraestructura? IdTipoInfraestructuraNavigation { get; set; }

    public virtual ICollection<NivelInfraestructura> NivelInfraestructuras { get; } = new List<NivelInfraestructura>();
}
