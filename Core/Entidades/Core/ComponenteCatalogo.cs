using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ComponenteCatalogo
{
    public int IdComponentec { get; set; }

    public string? CodigoMateriac { get; set; }

    public string? NombreComponentec { get; set; }

    public string? CodigoComponentec { get; set; }

    public int? NumprofesorComponentc { get; set; }

    public double? PesoComponentec { get; set; }

    public double? MinimoComponentec { get; set; }

    public double? CreditosComponentec { get; set; }

    public int? CuposComponentec { get; set; }

    public double? HorassemestreComponentec { get; set; }

    public virtual CatalogoMateria? CodigoMateriacNavigation { get; set; }
}
