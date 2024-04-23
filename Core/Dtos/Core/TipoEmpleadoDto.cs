using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoEmpleadoDto
    {
        public int IdTipoEmp { get; set; }

        public string? NombreTipoEmp { get; set; }

        public string? DescripcionTipoEmp { get; set; }

        public bool? ActivoTipoEmp { get; set; }
    }
}
