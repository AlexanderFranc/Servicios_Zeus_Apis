using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class PaisDto
    {
        public int IdPais { get; set; }

        public string? CodigoPais { get; set; }

        public string? NombrePais { get; set; }

        public bool? ActivoPais { get; set; }
    }
}
