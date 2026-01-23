using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class InfraestructuraDto
    {
        public int IdInfraestructura { get; set; }

        [Required(ErrorMessage = "El campus es requerido")]
        public int? IdCampus { get; set; }

        [Required(ErrorMessage = "El tipo de infraestructura es requerido")]
        public int? IdTipoInfraestructura { get; set; }

        [Required(ErrorMessage = "El código es requerido")]
        public string? CodigoInfraestructura { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string? NombreInfraestructura { get; set; }

        public string? ReferenciaInfraestructura { get; set; }

        public string? NombreCampus { get; set; }

        public bool? ActivoInfraestructura { get; set; }
    }
}
