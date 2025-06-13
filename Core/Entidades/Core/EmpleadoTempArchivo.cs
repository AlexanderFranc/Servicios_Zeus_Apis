using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EmpleadoTempArchivo
{
    public int Id { get; set; }

    public int IdEmpNuevo { get; set; }

    public int IdTipoArchivo { get; set; }

    public string PathArchivo { get; set; } = null!;
}
