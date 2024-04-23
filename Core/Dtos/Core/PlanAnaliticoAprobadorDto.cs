using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PlanAnaliticoAprobadorDto
    {
        public int IdPlanAnalitico { get; set; }
        public int? IdPlanEstudio { get; set; }
        public int? IdCarrera { get; set; }
        public string? NombreCarrera { get; set; }
        public int? IdFacultad { get; set; }
        public string? NombreFacultad { get; set; }
        public int IdMateria { get; set; }
        public string? NombreMateria { get; set; }
        public string? CodigoMateria { get; set; }
        public int IdMalla { get; set; }
        public string IdentificacionUsuElabora { get; set; }
        public string? FechaElabora { get; set; }

        public int? EstadoAprobado {  get; set; }
        public string? FechaAprueba { get; set; }
        public string? UsuarioAprueba { get; set; }
        public string? PathDocumento { get; set; }

    }
}
