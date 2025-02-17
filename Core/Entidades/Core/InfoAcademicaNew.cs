using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InfoAcademicaNew
{
    public int IdInfoAcademica { get; set; }

    public int IdEmp { get; set; }

    public int IdNivelAcademico { get; set; }

    public int IdPais { get; set; }

    public int? IdCampoEspecifico { get; set; }

    public int IdUnidadEducativa { get; set; }

    public string? Institucion { get; set; }

    public string Titulo { get; set; } = null!;

    public DateTime? FechaEmsision { get; set; }

    public DateTime? FechaRegSenecyt { get; set; }

    public string? CertificadoTitulo { get; set; }

    public string? CertificadoSenecyt { get; set; }

    public string? Ciudad { get; set; }

    public string? Uc { get; set; }

    public DateTime? Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public string? UAprueba { get; set; }

    public DateTime? FAprueba { get; set; }

    public bool? AprobadoTh { get; set; }

    public virtual Empleado IdEmpNavigation { get; set; } = null!;

    public virtual NivelAcademico IdNivelAcademicoNavigation { get; set; } = null!;

    public virtual UnidadEducativa IdUnidadEducativaNavigation { get; set; } = null!;
}
