using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class SolicitudEmpleadoDto
    {
        public int IdEmpNuevo { get; set; }
        public int IdFacultad { get; set; }
        public string CodigoFacultad { get; set; }
        public string NombreFacultad { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string TipoContrato { get; set; }
        public DateTime? FC { get; set; }
        public string? UA { get; set; } = null!;
        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string Motivo { get; set; }
        public string Observacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Periodo { get; set; }       
        public string? Dedicacion { get; set; }
    }
}
