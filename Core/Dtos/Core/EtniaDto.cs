using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class EtniaDto
    {
        public int IdEtnia { get; set; }

        public string Etnia { get; set; } = null!;

        public bool Activo { get; set; }
    }
}
