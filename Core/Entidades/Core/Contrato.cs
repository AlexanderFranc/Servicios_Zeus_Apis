using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Contrato
{
    public int IdContrato { get; set; }

    public int? IdModalidadContrato { get; set; }

    public int? IdEmp { get; set; }

    public int? IdEstadoContrato { get; set; }

    public int? IdTipoContrato { get; set; }

    public string? NumeroContrato { get; set; }

    public DateTime? FechaRegistroContrato { get; set; }

    public DateTime? FechaActualizaContrato { get; set; }

    public double? RmuContrato { get; set; }

    public int? IdconcursoContrato { get; set; }

    public DateTime? FechainicioContrato { get; set; }

    public DateTime? FechafinContrato { get; set; }

    public bool? ActivoContrato { get; set; }

    public int? IdContratoModalidad { get; set; }

    public virtual ICollection<GestionDocumental> GestionDocumentals { get; } = new List<GestionDocumental>();

    public virtual ICollection<HistorialContrato> HistorialContratos { get; } = new List<HistorialContrato>();

    public virtual Empleado? IdEmpNavigation { get; set; }

    public virtual EstadoContrato? IdEstadoContratoNavigation { get; set; }

    public virtual ModalidadContrato? IdModalidadContratoNavigation { get; set; }

    public virtual TipoContrato? IdTipoContratoNavigation { get; set; }
}
