using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class RequisitosTipoContrato
{
    public int IdRequisitosTipoContrato { get; set; }

    public int? IdTipoContrato { get; set; }

    public int? IdCatalogodocumentosrequisitosTipoContrato { get; set; }

    public virtual TipoContrato? IdTipoContratoNavigation { get; set; }
}
