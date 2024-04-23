using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class AutoridadesInstitucionEducativa
{
    public int IdAutoridadesue { get; set; }

    public int? IdTipoAie { get; set; }

    public int? IdInstitucionEducativa { get; set; }

    public string? NombresAutoridadesue { get; set; }

    public string? ApellidoAutoridadesue { get; set; }

    public string? DniAutoridadesue { get; set; }

    public string? TipodocAutoridadesue { get; set; }

    public string? PathfirmadAutoridadesue { get; set; }

    public string? PathfirmaeAutoridadesue { get; set; }

    public string? ClavefirmaeAutoridadesue { get; set; }

    public bool? GuardaclavefirmaeAutoridadesue { get; set; }

    public bool? ActivoAutoridadesue { get; set; }

    public virtual InstitucionEducativa? IdInstitucionEducativaNavigation { get; set; }

    public virtual TipoAutoridadInstitucionEducativa? IdTipoAieNavigation { get; set; }
}
