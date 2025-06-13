using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ContactoEmergenciaDto
    {
        public int IdContactoEmergencia { get; set; }

        public int? IdEmp { get; set; }

        public string Contacto { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string? Celular { get; set; }

        public string Relacion { get; set; } = null!;       
        public string? UC { get; set; }
        public DateTime? FC { get; set; }
        public string? UA { get; set; }
        public DateTime? FA { get; set; }
        public string? UAprueba { get; set; }
        public DateTime? FAprueba { get; set; }
        public bool? AprobadoTH { get; set; }
    }
}
