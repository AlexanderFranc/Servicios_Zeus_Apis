using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class UnidadEducativaDto
    {
        public int IdUnidadEducativa { get; set; }

        public int? TipoUnidadEducativa { get; set; }

        public string? CodigoUnidadEducativa { get; set; }

        public string? NombreUnidadEducativa { get; set; }

        public bool? ActivoUnidadEducativa { get; set; }
    }
}
