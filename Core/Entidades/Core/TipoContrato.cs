using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class TipoContrato
{
    public int IdTipoContrato { get; set; }

    public int? IdDedicacion { get; set; }

    public int? IdPartida { get; set; }

    public string? NombreTipoContrato { get; set; }

    public bool? ActivoTipoContrato { get; set; }

    public virtual ICollection<Contrato> Contratos { get; } = new List<Contrato>();

    public virtual Dedicacion? IdDedicacionNavigation { get; set; }

    public virtual PartidaPresupuestarium? IdPartidaNavigation { get; set; }

    public virtual ICollection<RelacionContrato> RelacionContratos { get; } = new List<RelacionContrato>();

    public virtual ICollection<RequisitosTipoContrato> RequisitosTipoContratos { get; } = new List<RequisitosTipoContrato>();
}
