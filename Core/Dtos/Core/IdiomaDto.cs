using Core.Dtos.Ftp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class IdiomaDto
    {
        public int IdIdioma { get; set; }

        public int IdEmp { get; set; }

        public string Idioma1 { get; set; } = null!;

        public string Institucion { get; set; } = null!;

        public string? Nivel { get; set; } = null!;

        public DateTime? FechaEmision { get; set; }

        public bool Certificacion { get; set; }

        public string? Certificado { get; set; }

        public string? UC { get; set; }
        public DateTime? FC { get; set; }
        public string? UA { get; set; }
        public DateTime? FA { get; set; }
        public string? UAprueba { get; set; }
        public DateTime? FAprueba { get; set; }
        public bool? AprobadoTH { get; set; }

    }
}