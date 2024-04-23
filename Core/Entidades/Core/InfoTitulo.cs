using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class InfoTitulo
{
    public int IdInfoTitulos { get; set; }

    public int? IdInfoAcademica { get; set; }

    public virtual InfoAcademica? IdInfoAcademicaNavigation { get; set; }
}
