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

    public int? IdUnidadEducativa { get; set; }

    public string? UnidadEducativa { get; set; }

    public string Titulo { get; set; } = null!;

    public int IdCampoAmplio { get; set; }

    public int? IdCampoEspecifico { get; set; }

    public int IdFacultad { get; set; }

    public int? IdTipoEmp { get; set; }

    public int IdTipoContrato { get; set; }

    public int IdDedicacion { get; set; }

    public string Horario { get; set; } = null!;

    public int? IdTitularidad { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdFormaPago { get; set; }

    public int? IdEstado { get; set; }

    public string? Uc { get; set; }

    public DateTime? Fc { get; set; }

    public string? Ua { get; set; }

    public DateTime? Fa { get; set; }

    public int? IdPeriodo { get; set; }

    public string? Motivo { get; set; }

    public string? Observacion { get; set; }

    public int? Nivel { get; set; }

    public virtual CampoAmplio IdCampoAmplioNavigation { get; set; } = null!;

    public virtual CampoEspecifico? IdCampoEspecificoNavigation { get; set; }

    public virtual CategoriaEmp? IdCategoriaNavigation { get; set; }

    public virtual EstadoSolicitud? IdEstadoNavigation { get; set; }

    public virtual Facultad IdFacultadNavigation { get; set; } = null!;

    public virtual FormaPagoEmp? IdFormaPagoNavigation { get; set; }

    public virtual TipoContratoN IdTipoContratoNavigation { get; set; } = null!;

    public virtual TipoEmpleado? IdTipoEmpNavigation { get; set; }

    public virtual TitularidadEmp? IdTitularidadNavigation { get; set; }
}
