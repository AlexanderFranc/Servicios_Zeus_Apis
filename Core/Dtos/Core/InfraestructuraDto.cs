using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class InfraestructuraDto
    {
        public int IdInfraestructura { get; set; }

        public int? IdCampus { get; set; }

        public int? IdTipoInfraestructura { get; set; }

        public string? CodigoInfraestructura { get; set; }

        public string? NombreInfraestructura { get; set; }

        public string? ReferenciaInfraestructura { get; set; }

        public bool? ActivoInfraestructura { get; set; }

        public int? IdCampusNavigation { get; set; }

        public int? IdTipoInfraestructuraNavigation { get; set; }
    }
}
