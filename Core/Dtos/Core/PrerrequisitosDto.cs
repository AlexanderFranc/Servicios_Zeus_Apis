using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PrerrequisitosDto
    {
        public int IdPrerequisito { get; set; }

        public int? IdMalla { get; set; }

        public int? IdMateria { get; set; }

        public int? IdNivelEstudio { get; set; }

        public int? IdPlanEstudio { get; set; }

        public int? IdTipoPrecorrequisito { get; set; }

        public int? IdTipoAprobacion { get; set; }

        public string? DescripcionPpestudios { get; set; }

        public bool? ActivoMateriaPpestudios { get; set; }

        public string? PathPrerrequsito { get; set; }
    }
}
