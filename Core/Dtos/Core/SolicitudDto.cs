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
        public string? UC { get; set; }
        public DateTime? FC { get; set; }
        public string? UA { get; set; }
        public DateTime? FA { get; set; }
    }
}
