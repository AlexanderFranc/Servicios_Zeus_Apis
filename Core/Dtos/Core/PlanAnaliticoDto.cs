using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PlanAnaliticoDto
    {
        public int IdPlanAnalitico { get; set; }

        public int? IdAsignatura { get; set; }

        public string? DescripcionAsig { get; set; }

        public string? ObjetivoGeneralAsig { get; set; }

        public string? ConsideracionOrientacion { get; set; }

        public string? ConsideracionIntegracion { get; set; }

        public string? UsuarioElabora { get; set; }

        public string? FechaElabora { get; set; }

        public string? UsuarioRevisa { get; set; }

        public string? FechaRevisa { get; set; }

        public string? UsuarioAprueba { get; set; }

        public string? FechaAprueba { get; set; }

        public int? IdPlanEstudio { get; set; }

        public int? IdMalla { get; set; }

        public int? EstadoAprobacion { get; set; }
        public string? PathDocumento { get; set; }

    }
}
