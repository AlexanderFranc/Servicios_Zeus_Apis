using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Ciudad
{
    public int IdCiudad { get; set; }

    public int? IdCanton { get; set; }

    public string? NombreCiudad { get; set; }

    public bool? ActivoCiudad { get; set; }

    public virtual Canton? IdCantonNavigation { get; set; }

    public virtual ICollection<Parroquium> Parroquia { get; } = new List<Parroquium>();
}
