using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class MateriaPrincipalDto
    {
        public int IdMateria { get; set; }

        public int? IdUoc { get; set; }

        public int? IdTipoAprobacion { get; set; }

        public string? CodigoMateriap { get; set; }

        public string? NombreMateriap { get; set; }

        public double? CreditosMateriap { get; set; }

        public int? HorasSemestralesMateriap { get; set; }

        public int? CuposMatriculaMateriap { get; set; }

        public string? CampoUnescoMateriap { get; set; }

        public bool? ActivoMateriap { get; set; }
        public int IdTipoMateriaCatalogo { get; set; }

        //public virtual TipoMateriaCatalogoDto idTipoMateriaCatalogoDTO { get; set; } = null!;
    }
}
