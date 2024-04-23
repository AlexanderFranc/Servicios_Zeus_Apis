using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entidades.Core;

namespace Core.Dtos.Core
{
    public class CantonDto
    {
        public int IdCanton { get; set; }

        public int? IdProvincia { get; set; }

        public string CodigoCanton { get; set; } = null!;

        public string NombreCanton { get; set; } = null!;

        public bool? ActivoCanton { get; set; }

        public virtual Provincium? IdProvinciaNavigation { get; set; }

    }
}
