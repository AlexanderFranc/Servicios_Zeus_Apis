using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Campus
{
    public int IdCampus { get; set; }

    public int? IdParroquia { get; set; }

    public int? IdSedeInstitucion { get; set; }

    public string? CodigoCampus { get; set; }

    public string? NombreCampus { get; set; }

    public string? CallePrincipalCampus { get; set; }

    public string? CalleSecundariaCampus { get; set; }

    public string? NumeroCampus { get; set; }

    public string? ReferenciaCampus { get; set; }

    public string? CodPostalCampus { get; set; }

    public string? TelefonoCampus { get; set; }

    public string? FaxCampus { get; set; }

    public string? EmailCampus { get; set; }

    public bool? ActivoCampus { get; set; }

    public virtual ICollection<Facultad> Facultads { get; } = new List<Facultad>();

    public virtual Parroquium? IdParroquiaNavigation { get; set; }

    public virtual SedeInstitucion? IdSedeInstitucionNavigation { get; set; }

    public virtual ICollection<Infraestructura> Infraestructuras { get; } = new List<Infraestructura>();

    public virtual ICollection<Permiso> Permisos { get; } = new List<Permiso>();
}
