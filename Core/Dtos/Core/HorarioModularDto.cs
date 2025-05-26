using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorarioModularDto
    {

        public DateTime? FechaI { get; set; }
        public DateTime? FechaF { get; set; }

        public string? HoraI { get; set; }

        public string? HoraF { get; set; }
        public int IdEspacioFisico { get; set; }
        public DateTime? FechaPlanificada { get; set; }

    }
}
