using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorarioFechaTempDto
    {
        public int IdPlanTemp { get; set; }
        public DateTime Fecha { get; set; }
        public TimeOnly? HoraIni { get; set; }
        public TimeOnly? HoraFin { get; set; }
        public int? OrdenFecha { get; set; }
        public Boolean? Activo { get; set; }
        public int? IdEspacioFisico { get; set; }

    }
}
