using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ProyectoInvestigacionDto
    {
        public int IdProyInves { get; set; }

        public int? IdEmp { get; set; }

        public string TituloPInv { get; set; } = null!;

        public int Duracion { get; set; }

        public string? Participantes { get; set; }
    }
}
