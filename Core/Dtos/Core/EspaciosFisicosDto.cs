using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class EspaciosFisicosDto
    {
        public int IdEspaciosFisicos { get; set; }

        public int? IdEstadoEspacio { get; set; }

        public int? IdTipoEspacio { get; set; }

        public int? IdNivelInfraestructura { get; set; }

        public string? CodigoEspaciosFisicos { get; set; }

        public string? DescripcionEspaciosFisicos { get; set; }

        public string? NombreEspaciosFisicos { get; set; }

        public double? AreaEspaciosFisicos { get; set; }

        public double? CapacidadTotalEspaciosFisicos { get; set; }

        public double? CapacidadParcialEspaciosFisicos { get; set; }

        public double? CapacidadVirtualEspaciosFisicos { get; set; }

        public bool? ActivoEspaciosFisicos { get; set; }
    }
}
