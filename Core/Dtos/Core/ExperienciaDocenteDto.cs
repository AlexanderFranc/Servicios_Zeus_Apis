using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Core.Dtos.Ftp;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class ExperienciaDocenteDto
    {
        public int IdExperienciaDocente { get; set; }

        public int IdEmp { get; set; }

        public int? IdUnidadEducativa { get; set; }

        public bool InstitucionSuperior { get; set; }

        public string? Institucion { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public bool Titular { get; set; }

        public string? CertificadoLaboral { get; set; }

        public string? CertificadoTitularidad { get; set; }
    }
}