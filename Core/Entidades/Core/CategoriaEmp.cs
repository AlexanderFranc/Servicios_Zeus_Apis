using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class CategoriaEmp
{
    public int IdCategoria { get; set; }

    public string Categoria { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<EmpleadoTempNuevo> EmpleadoTempNuevos { get; } = new List<EmpleadoTempNuevo>();
}
