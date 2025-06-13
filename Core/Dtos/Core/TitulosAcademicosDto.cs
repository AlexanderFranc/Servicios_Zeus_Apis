using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TitulosAcademicosDto
    {
        public string? Identificacion { get; set; }
        public int IdInfoAcademica { get; set; }

        public int IdEmp { get; set; }

        public int IdNivelAcademico { get; set; }

        public int IdPais { get; set; }

        public int? IdCampoEspecifico { get; set; }

        public int IdUnidadEducativa { get; set; }

        public string? Institucion { get; set; }

        public string Titulo { get; set; } = null!;

        public DateTime? FechaEmsision { get; set; }

        public DateTime? FechaRegSenecyt { get; set; }

        public string? CertificadoTitulo { get; set; }

        public string? CertificadoSenecyt { get; set; }

        public string? Ciudad { get; set; }

        public string? NivelAcademico1 { get; set; }
    }
}
