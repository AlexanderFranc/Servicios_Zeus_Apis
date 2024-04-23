using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class CampoEspecificoDto
    {
        public int IdCe { get; set; }

        public int? IdCa { get; set; }

        public string CodigoCe { get; set; } = null!;

        public string CampoEspecifico1 { get; set; } = null!;
    }
}
