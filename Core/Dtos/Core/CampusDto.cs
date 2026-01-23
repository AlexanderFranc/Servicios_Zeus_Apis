using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class CampusDto
    {
        public int IdCampus { get; set; }
        
        [Required(ErrorMessage = "El código del campus es requerido")]
        public string? CodigoCampus { get; set; }
        
        [Required(ErrorMessage = "El nombre del campus es requerido")]
        public string? NombreCampus { get; set; }
        
        public bool? ActivoCampus { get; set; }
    }
}
