using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class DuracionMateriaPrincipal
{
    public int IdDuracionMateriap { get; set; }

    public int? IdMateriap { get; set; }

    public string? NombreDuracionMateriap { get; set; }

    public bool? ActivoDuracionMateriap { get; set; }

    public virtual MateriaPrincipal? IdMateriapNavigation { get; set; }
}
