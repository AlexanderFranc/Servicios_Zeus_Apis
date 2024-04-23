using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class UnidadOrganizativaDto
    {
        public int IdUo { get; set; }

        public string UnidadOrganizativa1 { get; set; } = null!;

        public string CodigoUo { get; set; } = null!;

        public int? IdFacultad { get; set; }

        public bool? ActivoUo { get; set; }
    }
}
