using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class UsuarioPaDto
    {
        public int Id { get; set; }

        public string DniProfesor { get; set; } = null!;

        public int? IdPlanEstudio { get; set; }

        public int IdMalla { get; set; }

        public int IdMateria { get; set; }

        public bool Activo { get; set; }
    }
}
