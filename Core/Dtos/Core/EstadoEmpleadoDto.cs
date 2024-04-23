using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class EstadoEmpleadoDto
    {
        public int IdEstadoEmp { get; set; }

        public string? NombreEstadoEmp { get; set; }

        public bool? ActivoEstadoEmp { get; set; }
    }
}
