using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class ComponenteMateriaMallaDto
    {
        public int IdPlanEstudio { get; set; }
        public int IdComponente { get; set; }
        public int IdMateria { get; set; }
        public int IdSubtipoComponente { get; set; }
        public string? CodigoComponente { get; set; }
        public string? CodigoSubtipoComponente { get; set; }
        public string? NombreSubtipoComponente { get; set; }
        public int? HorasComponente { get; set; }
        public double? PesoComponente { get; set; }
        public int IdPeriodo { get; set; }

    }
}
