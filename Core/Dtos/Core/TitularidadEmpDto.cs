using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TitularidadEmpDto
    {
        public int IdTitularidad { get; set; }

        public int? IdDedicacion { get; set; }

        public string? Titularidad { get; set; }

        public bool? Activo { get; set; }

    }
}
