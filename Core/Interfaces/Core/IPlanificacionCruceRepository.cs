using Core.Dtos.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IPlanificacionCruceRepository : IGenericRepository<PlanificacionCruceDto>
    {
        List<PlanificacionCruceDto> GetPlanificacionCruce(string opcion, int idplanificacion, int idperiodo, int idespaciosfisicos, string codprofe);
    }
}
