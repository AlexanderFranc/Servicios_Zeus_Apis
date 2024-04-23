using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PlanEstudioDto
    {

        public int IdPlanEstudio { get; set; }

        public int? IdEstadoPe { get; set; }

        public int? IdCarrera { get; set; }

        public int? IdModalidadPe { get; set; }

        public string? CodigoPlanEstudioMalla { get; set; }

        public string? NumerodecretoCesMalla { get; set; }

        public string? PathdecretoCesMalla { get; set; }

        public int? DuracionSemestresMalla { get; set; }

        public int? PeriodicidadMalla { get; set; }

        public int? CupoCesMalla { get; set; }

        public DateTime? FechaAprobacionMalla { get; set; }

        public DateTime? FechaVigenciaMalla { get; set; }

        public string? SemestreInicioMalla { get; set; }

        public string? SemestreFinMalla { get; set; }

        public string? PathresolucionactivaMalla { get; set; }

        public string? PathresolucioncierreMalla { get; set; }

        public string? ObservacionesMalla { get; set; }

        public bool? ActivoMalla { get; set; }

        public virtual ICollection<ComponenteDto> Componentes { get; set; } = new List<ComponenteDto>();

        public virtual ICollection<MallaDto> Mallas { get; set; } = new List<MallaDto>();
        public virtual ModalidadPEDto IdModalidadPeNavigation { get; set; }
    }
}
