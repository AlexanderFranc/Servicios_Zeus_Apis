using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DetallesEspacio
{
    public int IdDetallesEspacio { get; set; }

    public int? IdEspaciosFisicos { get; set; }

    public double? Coordenadax1DetallesEspacio { get; set; }

    public double? Coordenadax2DetallesEspacio { get; set; }

    public double? Coordenaday1DetallesEspacio { get; set; }

    public double? Coordenaday2DetallesEspacio { get; set; }

    public string? ObservacionesDetallesEspacio { get; set; }

    public bool? ActivoDetallesEspacio { get; set; }

    public virtual EspaciosFisico? IdEspaciosFisicosNavigation { get; set; }
}
