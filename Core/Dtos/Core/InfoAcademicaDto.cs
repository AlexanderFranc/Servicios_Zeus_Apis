using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class InfoAcademicaDto
    {
        public int IdInfoAcademica { get; set; }

        public int IdEmp { get; set; }

        public int IdNivelAcademico { get; set; }

        public int IdCiudad { get; set; }

        public string Institucion { get; set; } = null!;

        public string Titulo { get; set; } = null!;

        public DateTime FechaEgresa { get; set; }

        public DateTime FechaRegSenecyt { get; set; }

        public string Certificado { get; set; } = null!;

        //public virtual Pai IdCiudadNavigation { get; set; } = null!;

        //public virtual Empleado IdEmpNavigation { get; set; } = null!;

        //public virtual NivelAcademico IdNivelAcademicoNavigation { get; set; } = null!;
    }
}
