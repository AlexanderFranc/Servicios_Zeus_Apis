using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class NivelInfraestructuraDto
    {
        public int IdNivelInfraestructura { get; set; }

        public int? IdInfraestructura { get; set; }

        public string? CodigoNivelInfraestructura { get; set; }

        public string? NombreNivelInfraestructura { get; set; }

        public bool? ActivoNivelInfraestructura { get; set; }

        public int? IdInfraestructuraNavigation { get; set; }
    }
}
