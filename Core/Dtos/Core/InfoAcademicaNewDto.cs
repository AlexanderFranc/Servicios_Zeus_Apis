using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dtos.Ftp;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public  class InfoAcademicaNewDto
    {
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
        public string? UC { get; set; }
        public DateTime? FC { get; set; }
        public string? UA { get; set; }
        public DateTime? FA { get; set; }
        public string? UAprueba { get; set; }
        public DateTime? FAprueba { get; set; }
        public bool? AprobadoTH { get; set; }

    }
}
