using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ProfesorSDto
    {
        public int IdPs { get; set; }
        public string DniProfesorc { get; set; }
        public int IdPlanificacion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Horas { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public string UC { get; set; } 
        public DateTime FC { get; set; }
        public string? UA { get; set; } = null!;
        public DateTime? FA { get; set; }

        public string? Docente { get; set; }
    }
}
