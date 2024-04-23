using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class NivelEstudioDto
    {
        public int IdNivelEstudio { get; set; }

        public string? CodigoNivelEstudio { get; set; }

        public string? NombreNivelEstudio { get; set; }

        public string? DescripcionNivelEstudio { get; set; }

        public bool? ActivoNivelEstudio { get; set; }
    }
}
