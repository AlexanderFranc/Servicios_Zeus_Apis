using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class TipoEspacioDto
    {
        public int IdTipoEspacio { get; set; }
        
        [Required(ErrorMessage = "El código es requerido")]
        public string? CodigoTipoEspacio { get; set; }
        
        [Required(ErrorMessage = "El nombre es requerido")]
        public string? NombreTipoEspacio { get; set; }
    }
}
