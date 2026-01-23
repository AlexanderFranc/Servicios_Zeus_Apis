using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class NivelInfraestructuraDto
    {
        public int IdNivelInfraestructura { get; set; }

        [Required(ErrorMessage = "La infraestructura es requerida")]
        public int? IdInfraestructura { get; set; }

        [Required(ErrorMessage = "El código es requerido")]
        public string? CodigoNivelInfraestructura { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string? NombreNivelInfraestructura { get; set; }

        public string? NombreInfraestructura { get; set; }

        public bool? ActivoNivelInfraestructura { get; set; }
    }
}
