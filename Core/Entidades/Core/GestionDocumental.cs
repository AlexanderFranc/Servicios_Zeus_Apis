using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class GestionDocumental
{
    public int IdDocumento { get; set; }

    public int? IdContrato { get; set; }

    public int? IdEstadoRequisitos { get; set; }

    public string? NombreDocumento { get; set; }

    public bool? EstadoDocumento { get; set; }

    public string? PathDocumento { get; set; }

    public virtual Contrato? IdContratoNavigation { get; set; }

    public virtual EstadoRequisito? IdEstadoRequisitosNavigation { get; set; }
}
