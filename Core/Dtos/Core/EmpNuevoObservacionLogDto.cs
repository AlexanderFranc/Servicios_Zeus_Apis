using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class EmpNuevoObservacionLogDto
    {
        public int Id { get; set; }
        public int IdEmpNuevo { get; set; }
        public string? UC { get; set; } = null!;
        public string? Usuario { get; set; } = null!;
        public DateTime? FC { get; set; } = null!;
        public string? Observacion { get; set; } = null!;

    }
}
