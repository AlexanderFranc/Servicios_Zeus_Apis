using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Solicitud
{
    public int IdSolicitud { get; set; }

    public string TipoSolicitud { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public int IdAsociado { get; set; }

    public int? IdEmpTempN { get; set; }

    public int IdEstado { get; set; }

    public string Motivo { get; set; } = null!;

    public string Observacion { get; set; } = null!;

    public string Uc { get; set; } = null!;

    public DateTime Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public int? IdPs { get; set; }

    public string? DniProfesors { get; set; }

    public bool? Profesors { get; set; }

    public bool? Equivalente { get; set; }

    public int? IdMallaEquiv { get; set; }

    public virtual EstadoSolicitud IdEstadoNavigation { get; set; } = null!;

    public virtual ICollection<PlanificacionTemp> PlanificacionTemps { get; } = new List<PlanificacionTemp>();
}
