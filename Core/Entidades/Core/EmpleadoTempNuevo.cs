using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class EmpleadoTempNuevo
{
    public int IdEmpNuevo { get; set; }

    public int TipoIdentificacion { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Celular { get; set; }

    public string Email { get; set; } = null!;

    public string? EmailInst { get; set; }

    public string Horario { get; set; } = null!;

    public int IdTipoContrato { get; set; }

    public int IdDedicacion { get; set; }

    public int IdCampoAmplio { get; set; }

    public int IdUnidadOrganizativa { get; set; }

    public string Titulo { get; set; } = null!;
}
