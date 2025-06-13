using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class LogObservacionSolicitudEmp
{
    public int Id { get; set; }

    public int IdEmpNuevo { get; set; }

    public string? Uc { get; set; }

    public DateTime Fc { get; set; }

    public string Observacion { get; set; } = null!;
}
