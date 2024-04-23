using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class AutoridadesCarrera
{
    public int IdAutoridadc { get; set; }

    public int? IdCarrera { get; set; }

    public int? IdTipoAutoridadc { get; set; }

    public string? NombredAutoridadc { get; set; }

    public string? ApellidosAutoridadc { get; set; }

    public string? DniAutoridadc { get; set; }

    public string? TipoDniAutoridadc { get; set; }

    public DateTime? FechaiAutoridadc { get; set; }

    public DateTime? FechafAutoridadc { get; set; }

    public DateTime? FecharegAutoridadc { get; set; }

    public byte[]? FechaactAutoridadc { get; set; }

    public string? EmailAutoridadc { get; set; }

    public string? TelefonoAutoridadc { get; set; }

    public bool? NombramientoAutoridadc { get; set; }

    public string? PathnombramientoAutoridadc { get; set; }

    public string? SemestresAutoridadc { get; set; }

    public string? PathfirmadAutoridadc { get; set; }

    public string? PathfirmaeAutoridadc { get; set; }

    public string? ClavefirmaeAutoridadc { get; set; }

    public bool? ActivoAutoridadc { get; set; }

    public virtual ICollection<ActAcademicasAutoridadCarrera> ActAcademicasAutoridadCarreras { get; } = new List<ActAcademicasAutoridadCarrera>();

    public virtual Carrera? IdCarreraNavigation { get; set; }

    public virtual TipoAutoridadCarrera? IdTipoAutoridadcNavigation { get; set; }
}
