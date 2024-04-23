using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoInfraestructuraDto
    {
        public int IdTipoInfraestructura { get; set; }

        public string? CodigoTipoInfraestructura { get; set; }

        public string? NombreTipoInfraestructura { get; set; }

        public bool? ActivoTipoInfraestructura { get; set; }
    }
}
