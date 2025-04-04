using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class CruceHorarioEstudianteDto
    {
        public string? Semestre { get; set; }
        public string? CodCli { get; set; }
        public string? CodMateria { get; set; }
        public string? Materia { get; set; }
        public int? Seccion { get; set; }
        public int? Nivel { get; set; }
        public string? CodPlan { get; set; }
        public string? CodMalla { get; set; }
        public double? Creditos { get; set; }
    }
}
