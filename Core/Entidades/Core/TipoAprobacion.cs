using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoAprobacion
{
    public int IdTipoAprobacion { get; set; }

    public string? NombreTipoAprobacion { get; set; }

    public string? CodigoTipoAprobacion { get; set; }

    public string? ObservacionesTipoAprobacion { get; set; }

    public bool? ActivoTipoAprobacion { get; set; }

    public virtual ICollection<Correquisito> Correquisitos { get; } = new List<Correquisito>();

    public virtual ICollection<Materium> Materia { get; } = new List<Materium>();

    public virtual ICollection<Prerrequisito> Prerrequisitos { get; } = new List<Prerrequisito>();
}
