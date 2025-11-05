using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class MateriaEquivalenteDto
    {
        public int IdPlanificacion { get; set; }

        public string CodigoPeriodo { get; set; } = null!;

        public string CodigoPlanEstudio { get; set; } = null!;
        public string CodigoMateria { get; set; } = null!;
        public string NombreMateria { get; set; } = null!;
        public string CodigoSubtipoComponente { get; set; } = null!;
        public string DniProfesorc { get; set; } = null!;
        public string Docente { get; set; } = null!;
        public string Paralelo { get; set; } = null!;

    }
}
    