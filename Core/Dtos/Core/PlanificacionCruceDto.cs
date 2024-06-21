using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PlanificacionCruceDto
    {
        public string? Cedula { get; set; }
        public string? Docente { get; set; }
        public string? Codigo { get; set; }
        public string? Materia { get; set; }
        public string? Aula { get; set; }
        public string? Dia { get; set; }
        public string? HoraIni { get; set; }
        public string? HoraFin { get; set; }

    }
}
