using Core.Entidades.Core;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class ParametrosActualizarParaleloDto
    {
        public string? Opcion { get; set; }
        public string? Semestre { get; set; }
        public string? Identificacion { get; set; }
	    public string? CodCarr { get; set; }
        public string? CodMateria { get; set; }
        public string? IdPlaniAC { get; set; }
        public string? IdPlaniAPE { get; set; }
    }
}
