using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class FormaPagoEmpDto
    {
        public int IdFPago { get; set; }

        public string? FPago { get; set; }

        public bool? Activo { get; set; }
    }
}
