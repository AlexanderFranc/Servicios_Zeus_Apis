using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoMateriaCatalogoDto
    {
        public int IdTipoMateriaCatalogo { get; set; }

        public string? NombreTipoMateriaCatalogo { get; set; }

        public string? DescripcionTipoMateriaCatalogo { get; set; }

        public bool? ActivoTipoMateriaCatalogo { get; set; }
    }
}
