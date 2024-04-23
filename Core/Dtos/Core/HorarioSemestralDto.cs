using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class HorarioSemestralDto
    {
        public string? horaIF { get; set; }
        public virtual ICollection<FechasHorarioSemetral> dias { get; set; } = new List<FechasHorarioSemetral>();

    }
}
