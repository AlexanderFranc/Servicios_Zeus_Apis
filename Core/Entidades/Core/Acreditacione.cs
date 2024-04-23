using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Acreditacione
{
    public int IdAcreditaciones { get; set; }

    public int? IdInstitucionEducativa { get; set; }

    public string? NombreAcreditaciones { get; set; }

    public DateTime? FechainicioAcreditaciones { get; set; }

    public DateTime? FechafinAcreditaciones { get; set; }

    public int? AniosAcreditaciones { get; set; }

    public string? UsuariocreaAcreditaciones { get; set; }

    public DateTime? FechacreaAcreditaciones { get; set; }

    public bool? ActivoAcreditaciones { get; set; }

    public virtual InstitucionEducativa? IdInstitucionEducativaNavigation { get; set; }
}
