using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public class MallaMateriaDto:MallaDto
    {

        public string? NombreMateria { get; set; }
        public string? CodigoMateria { get; set; }
        public double? CreditosMateria { get; set; }
        public int? HorasSemestralesMateria { get; set; }
        public virtual ICollection<Prerrequisito> Prerrequisitos { get; set; } = new List<Prerrequisito>();


    }
}
