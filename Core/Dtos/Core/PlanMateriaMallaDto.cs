using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class PlanMateriaMallaDto
    {
        public string Id { get; set; }  
        public int IdPlanEstudio { get; set; }
        public string? CodigoPlanEstudioMalla { get; set; }
        public int IdMateria { get; set; }
        public string? CodigoMateria { get; set; }
        public string? NombreMateria { get; set; }
    }
}
