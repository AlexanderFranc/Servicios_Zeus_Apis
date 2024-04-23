using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class HistoricoCarrera
{
    public int IdHistoricoc { get; set; }

    public int? IdCarrera { get; set; }

    public string? NombreHistoricoc { get; set; }

    public string? DescripcionHistoricoc { get; set; }

    public string? CodigoHistoricoc { get; set; }

    public string? ResolucionHistoricoc { get; set; }

    public DateTime? FechacreaHistoricoc { get; set; }

    public DateTime? FechaactHistoricoc { get; set; }

    public DateTime? FechacierreHistoricoc { get; set; }

    public DateTime? FecharegistroHistoricoc { get; set; }

    public string? PathHistoricoc { get; set; }

    public bool? ActivoHistoricoc { get; set; }

    public virtual Carrera? IdCarreraNavigation { get; set; }
}
