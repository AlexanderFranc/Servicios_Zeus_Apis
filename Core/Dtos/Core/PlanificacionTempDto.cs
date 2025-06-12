using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PlanificacionTempDto
    {
        public int IdPlanTemp { get; set; }
        public int IdSolicitud { get; set; }
        public int? IdPlanificacion { get; set; }
        public int IdMalla { get; set; }
        public int? IdPeriodo { get; set; }
        public int? IdModalidadPlanificacion { get; set; }
        public int? IdPeriodicidadPlanificacion { get; set; }
        public string? DniProfesorc { get; set; }
        public int? IdTipoComponente { get; set; }
        public string? Paralelo { get; set; }
        public int? IdEspaciosFisicos { get; set; }
        public int? Cupo { get; set; }
        public Boolean? Activo { get; set; }
        public DateTime? FechaInicioPlanificacion { get; set; }
        public DateTime? FechaFinPlanificacion { get; set; }


    }
}
