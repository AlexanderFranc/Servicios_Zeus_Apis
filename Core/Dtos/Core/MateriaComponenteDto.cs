using Core.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos.Core
{
    public  class MateriaComponenteDto // es la principal
    {
        public PlanMateriaMallaDto planMateriaMallaDto { get; set; }
        public virtual ICollection<ComponenteMateriaMallaDto> componentesMateriaDto { get; set; } = new List<ComponenteMateriaMallaDto>();
    }
}
