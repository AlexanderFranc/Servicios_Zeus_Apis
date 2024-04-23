using Core.Dtos.Ftp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class CapacitacionDto
    {
        public int IdCapacitacion { get; set; }

        public int IdEmp { get; set; }

        public int? IdTipoAprobacion { get; set; }

        public int? IdTipoActividad { get; set; }

        public string Institucion { get; set; } = null!;

        public string Titulo { get; set; } = null!;

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public int? Duracion { get; set; }

        public string? Certificado { get; set; }

        public List<SubirFtpArchivosBytesDto> FtpCapacitacion { get; set; } = new List<SubirFtpArchivosBytesDto>();
    }
}