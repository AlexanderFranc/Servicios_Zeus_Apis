using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    //'VHC','2025-3','QMED/45/1105162','16210','17422','MEDBASM2BI'
    public class ParametroEstudianteMatriculadoDto
    {
        public string TipoParametro { get; set; }
        public string Semestre { get; set; }
        public string CodCli { get; set; }
        public int IdPlanificacionAc { get; set; }
        public int? IdPlanificacionApe { get; set; }
        public string CodMateria { get; set; }


    }
}
