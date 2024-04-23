using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class AutoridadesFacultad
{
    public int IdAutoridadf { get; set; }

    public int? IdTipoautoridadf { get; set; }

    public int? IdFacultad { get; set; }

    public string? NombresAutoridadc { get; set; }

    public string? ApellidosAutoridadf { get; set; }

    public string? DniAutoridadf { get; set; }

    public string? TipoDniAutoridadf { get; set; }

    public bool? ActivoAutoridadf { get; set; }

    public DateTime? FechaiAutoridadf { get; set; }

    public DateTime? FechafAutoridadf { get; set; }

    public DateTime? FecharegAutoridadf { get; set; }

    public DateTime? FechaactAutoridadf { get; set; }

    public string? EmailAutoridadf { get; set; }

    public string? TelefonoAutoridadf { get; set; }

    public bool? NombramientoAutoridadf { get; set; }

    public string? PathnombramientoAutoridadf { get; set; }

    public string? SemestresAutoridadf { get; set; }

    public string? PathfirmadAutoridadf { get; set; }

    public string? PathfirmaeAutoridadf { get; set; }

    public string? ClavefirmaeAutoridadf { get; set; }

    public virtual Facultad? IdFacultadNavigation { get; set; }

    public virtual TipoAutoridadfacultad? IdTipoautoridadfNavigation { get; set; }
}
