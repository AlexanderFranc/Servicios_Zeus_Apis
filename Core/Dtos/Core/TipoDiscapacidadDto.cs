using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoDiscapacidadDto
    {
        public int IdTipoDiscapacidad { get; set; }

        public string TipoDiscapacidad1 { get; set; } = null!;

        public bool Activo { get; set; }
    }
}
