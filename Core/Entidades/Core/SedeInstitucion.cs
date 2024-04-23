using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class SedeInstitucion
{
    public int IdSedeInstitucion { get; set; }

    public int? IdInstitucionEducativa { get; set; }

    public string? NombreSedeInstitucion { get; set; }

    public string? CodigoSedeInstitucion { get; set; }

    public bool? ActivoSedeInstitucion { get; set; }

    public virtual ICollection<Campus> Campuses { get; } = new List<Campus>();

    public virtual InstitucionEducativa? IdInstitucionEducativaNavigation { get; set; }
}
