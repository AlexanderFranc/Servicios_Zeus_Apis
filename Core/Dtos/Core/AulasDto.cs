using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class AulasDto
    {
        public int IdCampus { get; set; }
        public string NombreCampus { get; set; } = null!;
        public int IdInfraestructura { get; set; }
        public string CodigoInfraestructura { get; set; } = null!;
        public string NombreInfraestructura { get; set; } = null!;
        public int IdNivelInfraestructura { get; set; }
        public string CodigoNivelInfraestructura { get; set; } = null!;
        public string NombreNivelInfraestructura { get; set; } = null!;
        public int IdEspaciosFisicos { get; set; }
        public string CodigoEspaciosFisicos { get; set; } = null!;
        public string CodigoTipoEspacio { get; set; } = null!;
        public string NombreTipoEspacio { get; set; } = null!;
        public int CapacidadTotalEspaciosFisicos { get; set; }

    }
}
