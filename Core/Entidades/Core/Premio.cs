using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Premio
{
    public int IdPremios { get; set; }

    public int? IdInstitucionEducativa { get; set; }

    public string? NombrePremios { get; set; }

    public string? OtorgaPremios { get; set; }

    public DateTime? FecahregPremios { get; set; }

    public bool? ActivoPremios { get; set; }

    public virtual InstitucionEducativa? IdInstitucionEducativaNavigation { get; set; }
}
