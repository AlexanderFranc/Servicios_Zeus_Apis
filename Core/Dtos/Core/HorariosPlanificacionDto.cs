using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorariosPlanificacionDto
    {
        public int id { get; set; }
        public TimeOnly horai { get; set; }
        public TimeOnly horaf { get; set; }
        public string dLunes { get; set; }
        public string dMartes { get; set; }
        public string dMiercoles { get; set; }
        public string dJueves { get; set; }
        public string dViernes { get; set; }
        public string dSabado { get; set; }

        public string CalendarDate { get; set; }
        public string idplanificacion { get; set; }

    }
}
