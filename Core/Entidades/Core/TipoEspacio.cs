using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoEspacio
{
    public int IdTipoEspacio { get; set; }

    public string? CodigoTipoEspacio { get; set; }

    public string? NombreTipoEspacio { get; set; }

    public string? ReferenciaTipoEspacio { get; set; }

    public virtual ICollection<EspaciosFisico> EspaciosFisicos { get; } = new List<EspaciosFisico>();
}
