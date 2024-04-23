using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class PeriodoDto
    {
        public int IdPeriodo { get; set; }

        public int IdPeriodicidad { get; set; }

        public int IdTipoPeriodo { get; set; }

        public int IdModalidad { get; set; }

        public int IdEstadoPeriodo { get; set; }

        public string? CodigoPeriodo { get; set; }

        public string? CodigoNumeroPeriodo { get; set; }

        public string? CodigoTextoPeriodo { get; set; }

        public string? DescripcionPeriodo { get; set; }

        public DateTime? FechaInicioPeriodo { get; set; }

        public DateTime? FechaFinPeriodo { get; set; }

        public DateTime? FechaRegistroPeriodo { get; set; }

        public DateTime? FechaActualizaPeriodo { get; set; }

        public bool? ActivoPeriodo { get; set; }

        public virtual ICollection<ControlesPeriodo> ControlesPeriodos { get; set; } = new List<ControlesPeriodo>();

        public virtual EstadoPeriodo IdEstadoPeriodoNavigation { get; set; } = null!;

        public virtual ModalidadPeriodo IdModalidadNavigation { get; set; } = null!;

        public virtual Periodicidad IdPeriodicidadNavigation { get; set; } = null!;

        public virtual TipoPeriodo IdTipoPeriodoNavigation { get; set; } = null!;

        public virtual ICollection<Planificacion> Planificacions { get; } = new List<Planificacion>();
    }
}
