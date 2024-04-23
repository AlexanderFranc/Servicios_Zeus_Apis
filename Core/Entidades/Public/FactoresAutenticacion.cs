using System;
using System.Collections.Generic;

namespace Core.Entidades.Public;

public partial class FactoresAutenticacion
{
    public int IdFa { get; set; }

    public string? TipoFa { get; set; }

    public string? CodigoappFa { get; set; }

    public DateTime? FechaFa { get; set; }

    public DateTime? ExpiraFa { get; set; }

    public string? EstadoFa { get; set; }

    public virtual ICollection<UsuarioFa> UsuarioFas { get; } = new List<UsuarioFa>();
}
