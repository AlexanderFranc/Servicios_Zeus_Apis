using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class CategoriaEmpDto
    {
        public int IdCategoria { get; set; }

        public string? Categoria { get; set; }

        public bool? Activo { get; set; }
    }
}
