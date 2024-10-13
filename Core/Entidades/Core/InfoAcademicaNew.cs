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

    public DateOnly? FechaEmsision { get; set; }

    public DateOnly? FechaRegSenecyt { get; set; }

    public string? CertificadoTitulo { get; set; }

    public string? CertificadoSenecyt { get; set; }

    public string? Ciudad { get; set; }

    public virtual Empleado IdEmpNavigation { get; set; } = null!;

    public virtual NivelAcademico IdNivelAcademicoNavigation { get; set; } = null!;

    public virtual UnidadEducativa IdUnidadEducativaNavigation { get; set; } = null!;
}
