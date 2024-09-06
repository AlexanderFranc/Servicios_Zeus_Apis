using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorarioTempDto
    {
        public int IdPlanTemp { get; set; }
        public int IdDia { get; set; }
        public string? HoraIni { get; set; }
        public string? HoraFin { get; set; }
        public Boolean? Activo { get; set; }
    }
}
