using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dtos.Ftp;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class ExperienciaLaboralDto
    {
        public int IdExperienciaLaboral { get; set; }

        public int? IdEmp { get; set; }

        public string? Institucion { get; set; } = null!;

        public string? Cargo { get; set; } = null!;

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public bool? Actualmente { get; set; }

        public decimal? Sueldo { get; set; }

        public string? RazonSalida { get; set; }

        public string? Contacto { get; set; }

        public string? CargoContacto { get; set; }

        public string? TelefonoContacto { get; set; }

        public string? Certificado { get; set; }

    }
}