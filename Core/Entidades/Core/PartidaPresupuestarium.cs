using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class PartidaPresupuestarium
{
    public int IdPartida { get; set; }

    public string? NombrePartida { get; set; }

    public double? ValorPartida { get; set; }

    public double? SaldoPartida { get; set; }

    public double? VinicialPartida { get; set; }

    public DateTime? FechacreaPartida { get; set; }

    public DateTime? FechacierrePartida { get; set; }

    public bool? ActivaPartida { get; set; }

    public virtual ICollection<TipoContrato> TipoContratos { get; } = new List<TipoContrato>();
}
