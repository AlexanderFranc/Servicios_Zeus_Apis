using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class PlanificacionDto1
    {

        public int IdMalla { get; set; }
        public int IdPeriodo { get; set; }
        public int IdModalidadPlanificacion { get; set; }
        public int IdPeriodicidadPlanificacion { get; set; }       
        public string DniProfesorc { get; set; } = null!;
        public int IdTipoComponente { get; set; }
        public string Paralelo { get; set; } = null!;
        public int IdEspaciosFisicos { get; set; }
        public int? Cupo { get; set; }
        public int IdPlanificacion { get; set; }
        public bool? Activo { get; set; }
        public string? UC { get; set; } = null!;
        public DateTime? FC { get; set; }
        public string? UA { get; set; } = null!;
        public DateTime? FA { get; set; }
    }
}
