using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class ContactoEmergencium
{
    public int IdContactoEmergencia { get; set; }

    public int? IdEmp { get; set; }

    public string Contacto { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Celular { get; set; }

    public string Relacion { get; set; } = null!;

    public string? Uc { get; set; }

    public DateTime? Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public string? UAprueba { get; set; }

    public DateTime? FAprueba { get; set; }

    public bool? AprobadoTh { get; set; }
}
