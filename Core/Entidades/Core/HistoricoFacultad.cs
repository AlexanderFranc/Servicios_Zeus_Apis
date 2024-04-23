using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HistoricoFacultad
{
    public int IdHfacultad { get; set; }

    public int? IdFacultad { get; set; }

    public string? NombreHfacultad { get; set; }

    public string? DescripcionHfacultad { get; set; }

    public string? CodigoHfacultad { get; set; }

    public string? ResolucionHfacultad { get; set; }

    public DateTime? FechacreaHfacultad { get; set; }

    public DateTime? FechaactHfacultad { get; set; }

    public DateTime? FechacierreHfacultad { get; set; }

    public DateTime? FecharegistroHfacultad { get; set; }

    public string? ParthHfacultad { get; set; }

    public bool? ActivoHfacultad { get; set; }

    public virtual Facultad? IdFacultadNavigation { get; set; }
}
