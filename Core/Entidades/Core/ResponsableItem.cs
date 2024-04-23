using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ResponsableItem
{
    public int IdResponsableItem { get; set; }

    public int? IdItem { get; set; }

    public string? DniResponsableItem { get; set; }

    public string? ObservacionResponsableItem { get; set; }

    public bool? ActivoResponsableItem { get; set; }

    public virtual Item? IdItemNavigation { get; set; }
}
