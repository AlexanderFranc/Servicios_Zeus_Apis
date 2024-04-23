using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ComponenteDto
    {
        public int IdComponente { get; set; }

        public int IdTipoComponente { get; set; }

        public int IdMateria { get; set; }

        public string? CodigoComponente { get; set; }

        public double? PesoComponente { get; set; }

        public bool? ActivoComponente { get; set; }
    }
}
