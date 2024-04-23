using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class MateriasPaDto
    {
        public int IdPlanEstudio { get; set; }
        public string? CodPlanEstudio { get; set; }
        public int IdCarrera { get; set; }
        public string? NombreCarrera { get; set; }
        public int? IdFacultad { get; set; }
        public string? NombreFacultad { get; set; }
        public int IdMateria { get; set; }
        public string? NombreMateria { get; set; }
        public string? CodigoMateria { get; set; }
        public int IdMalla { get; set; }
        public string Identificacion { get; set; }
    }
}
