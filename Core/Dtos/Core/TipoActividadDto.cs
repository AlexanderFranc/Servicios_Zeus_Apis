using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoActividadDto
    {
        public int IdTipoActividad { get; set; }

        public string TipoActividad1 { get; set; } = null!;

        public bool Activo { get; set; }
    }
}
