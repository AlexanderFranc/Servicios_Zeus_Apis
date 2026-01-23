using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class EspaciosFisicosDto
    {
        public int IdEspaciosFisicos { get; set; }

        [Required(ErrorMessage = "El estado del espacio es requerido.")]
        public int? IdEstadoEspacio { get; set; }

        [Required(ErrorMessage = "El tipo de espacio es requerido.")]
        public int? IdTipoEspacio { get; set; }

        [Required(ErrorMessage = "El nivel de infraestructura es requerido.")]
        public int? IdNivelInfraestructura { get; set; }

        [Required(ErrorMessage = "El código es requerido.")]
        [StringLength(50, ErrorMessage = "El código no puede exceder 50 caracteres.")]
        public string? CodigoEspaciosFisicos { get; set; }

        public string? DescripcionEspaciosFisicos { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? NombreEspaciosFisicos { get; set; }

        public string? NombreTipoEspacio { get; set; }

        public string? NombreEstadoEspacio { get; set; }

        public string? NombreNivelInfraestructura { get; set; }

        public string? NombreInfraestructura { get; set; }

        public string? NombreCampus { get; set; }

        public double? AreaEspaciosFisicos { get; set; }

        [Range(1, 999, ErrorMessage = "La capacidad debe ser mayor a 0.")]
        public double? CapacidadTotalEspaciosFisicos { get; set; }

        public double? CapacidadParcialEspaciosFisicos { get; set; }

        public double? CapacidadVirtualEspaciosFisicos { get; set; }

        public bool? ActivoEspaciosFisicos { get; set; }
    }
}
