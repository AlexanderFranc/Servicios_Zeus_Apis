using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class SolicitudDto
    {
        public int IdSolicitud { get; set; }
        public string TipoSolicitud { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int? IdAsociado { get; set; }
        public int? IdEmpTempN { get; set; }
        public int? IdEstado { get; set; }
        public string? Motivo { get; set; }
        public string? Observacion { get; set; }
        public string? UC { get; set; } = null!;
        public DateTime? FC { get; set; }
        public string? UA { get; set; } = null!;
        public DateTime? FA { get; set; }

        public int? idPS { get; set; }
        public string? dniProfesorS { get; set; }
        public bool? profesorS { get; set; }

        public bool? equivalente { get; set; }

        public int? IdMallaEquiv { get; set; }
    }
}
