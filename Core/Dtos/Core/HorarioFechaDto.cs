using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorarioFechaDto
    {
        public int? IdPlanificacion { get; set; }

        public DateTime? Fecha { get; set; }

        public TimeOnly? HoraIni { get; set; }

        public TimeOnly? HoraFin { get; set; }
    }
}
