using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoComponenteSubtipoDto: SubtipoComponenteDto
    {
        public int IdTipoComponente { get; set; }

        public string? CodigoTipoComponente { get; set; }

        public string? NombreTipoComponente { get; set; }

    }
}
