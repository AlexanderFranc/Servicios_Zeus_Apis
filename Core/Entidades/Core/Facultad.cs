using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Facultad
{
    public int IdFacultad { get; set; }

    public int? IdEstadoFacultad { get; set; }

    public int? IdCampus { get; set; }

    public string? NombreFacultad { get; set; }

    public string? DescripcionFacultad { get; set; }

    public string? CodigoFacultad { get; set; }

    public string? ResolucionFacultad { get; set; }

    public DateTime? FechacreaFacultad { get; set; }

    public DateTime? FechaactFacultad { get; set; }

    public DateTime? FechacierreFacultad { get; set; }

    public DateTime? FecharegistroFacultad { get; set; }

    public bool? ActivoFacultad { get; set; }

    public virtual ICollection<AutoridadesFacultad> AutoridadesFacultads { get; } = new List<AutoridadesFacultad>();

    public virtual ICollection<Carrera> Carreras { get; } = new List<Carrera>();

    public virtual ICollection<DesignacionesFacultad> DesignacionesFacultads { get; } = new List<DesignacionesFacultad>();

    public virtual ICollection<HistoricoFacultad> HistoricoFacultads { get; } = new List<HistoricoFacultad>();

    public virtual Campus? IdCampusNavigation { get; set; }

    public virtual EstadoFacultad? IdEstadoFacultadNavigation { get; set; }
}
