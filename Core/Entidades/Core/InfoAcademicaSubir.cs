using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InfoAcademicaSubir
{
    public double? Identificacion { get; set; }

    public string? NivelAcademico { get; set; }

    public string? Pais { get; set; }

    public string? Ciudad { get; set; }

    public string? Institucion { get; set; }

    public string? InstitucionExtranjera { get; set; }

    public string? Titulo { get; set; }

    public string? CampoAmplio { get; set; }

    public string? CampoEspecifico { get; set; }

    public DateTime? FechaEmisionTitulo { get; set; }

    public DateTime? FechaRegSenecyt { get; set; }

    public string? NumeroDeRegistro { get; set; }

    public string? F13 { get; set; }

    public string? F14 { get; set; }

    public string? F15 { get; set; }
}
