using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class EstadoEspacioDto
    {
        public int IdEstadoEspacio { get; set; }
        
        [Required(ErrorMessage = "El nombre del estado es requerido")]
        public string? NombreEstadoEspacio { get; set; }
        
        public string? Nombre { get; set; }
        public string? Label { get; set; }
        public string? Descripcion { get; set; }
        public bool? ActivoEstadoEspacio { get; set; }
    }
}
