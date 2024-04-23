using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class SubtipoComponenteDto
    {
        public int IdSubtipoComponente { get; set; }

        public int IdTipoComponente { get; set; }

        public string? CodigoSubtipoComponente { get; set; }

        public string? NombreSubtipoComponente { get; set; }

        public string? DescripcionSubtipoComponente { get; set; }

        public bool? IncluyeDedicacionDocenteSubtipoComponente { get; set; }

        public bool? ActivoSubtipoComponente { get; set; }
    }
}
