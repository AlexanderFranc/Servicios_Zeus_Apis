using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EspaciosFisico
{
    public int IdEspaciosFisicos { get; set; }

    public int? IdEstadoEspacio { get; set; }

    public int? IdTipoEspacio { get; set; }

    public int? IdNivelInfraestructura { get; set; }

    public string? CodigoEspaciosFisicos { get; set; }

    public string? DescripcionEspaciosFisicos { get; set; }

    public string? NombreEspaciosFisicos { get; set; }

    public double? AreaEspaciosFisicos { get; set; }

    public double? CapacidadTotalEspaciosFisicos { get; set; }

    public double? CapacidadParcialEspaciosFisicos { get; set; }

    public double? CapacidadVirtualEspaciosFisicos { get; set; }

    public bool? ActivoEspaciosFisicos { get; set; }

    public string? MacEthernet { get; set; }

    public string? MacWlan { get; set; }

    public virtual ICollection<DetallesEspacio> DetallesEspacios { get; } = new List<DetallesEspacio>();

    public virtual ICollection<FechasHorario> FechasHorarios { get; } = new List<FechasHorario>();

    public virtual ICollection<FranjaHorario> FranjaHorarios { get; } = new List<FranjaHorario>();

    public virtual EstadoEspacio? IdEstadoEspacioNavigation { get; set; }

    public virtual NivelInfraestructura? IdNivelInfraestructuraNavigation { get; set; }

    public virtual TipoEspacio? IdTipoEspacioNavigation { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<OcupanteHorario> OcupanteHorarios { get; } = new List<OcupanteHorario>();

    public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();
}
