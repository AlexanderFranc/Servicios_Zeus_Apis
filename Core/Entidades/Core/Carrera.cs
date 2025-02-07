using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Carrera
{
    public int IdCarrera { get; set; }

    public int? IdFacultad { get; set; }

    public int? IdEstadoCarrera { get; set; }

    public string? CodigoCarrera { get; set; }

    public string? NombreCarrera { get; set; }

    public string? SiglasCarrera { get; set; }

    public string? TituloCarrera { get; set; }

    public string? MencionCarrera { get; set; }

    public string? PathdecretoAprobacionCarrera { get; set; }

    public DateTime? FechacreaCarrera { get; set; }

    public DateTime? FechaactCarrera { get; set; }

    public DateTime? FechacierraCarrera { get; set; }

    public bool? ActivoCarrera { get; set; }

    public int? IdNivelEstudio { get; set; }

    public int? IdCa { get; set; }

    public int? IdCe { get; set; }

    public int? IdCd { get; set; }

    public virtual ICollection<AutoridadesCarrera> AutoridadesCarreras { get; } = new List<AutoridadesCarrera>();

    public virtual ICollection<DesignacionesCarrera> DesignacionesCarreras { get; } = new List<DesignacionesCarrera>();

    public virtual ICollection<HistoricoCarrera> HistoricoCarreras { get; } = new List<HistoricoCarrera>();

    public virtual EstadoCarrera? IdEstadoCarreraNavigation { get; set; }

    public virtual Facultad? IdFacultadNavigation { get; set; }

    public virtual ICollection<PermisosCarrera> PermisosCarreras { get; } = new List<PermisosCarrera>();

    public virtual ICollection<PlanEstudio> PlanEstudios { get; } = new List<PlanEstudio>();
}
