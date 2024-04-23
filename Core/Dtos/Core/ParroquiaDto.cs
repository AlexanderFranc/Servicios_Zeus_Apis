using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ParroquiaDto
    {
        public int IdParroquia { get; set; }

        public int? IdCanton { get; set; }

        public string CodigoParroquia { get; set; } = null!;

        public string NombreParroquia { get; set; } = null!;

        public bool? ActivoParroquia { get; set; }

    }
}
