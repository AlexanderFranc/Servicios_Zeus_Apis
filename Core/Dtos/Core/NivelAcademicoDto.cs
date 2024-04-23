using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class NivelAcademicoDto
    {
        public int IdNivelAcademico { get; set; }

        public string NivelAcademico1 { get; set; } = null!;

        public bool Activo { get; set; }

        //public virtual ICollection<InfoAcademica> InfoAcademicas { get; } = new List<InfoAcademica>();
    }
}
