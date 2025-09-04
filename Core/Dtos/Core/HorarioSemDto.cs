using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorarioSemDto
    {
        public int IdPlanificacion { get; set; }

        public int? IdDia { get; set; }    
        public string? HoraI { get; set; }

        public string? HoraF { get; set; }
        public int IdEspacioFisico { get; set; }
        

    }
}
