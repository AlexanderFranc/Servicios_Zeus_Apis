using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IPlanificacionRepository1 : IGenericRepository<Planificacion>
    {
        //CAMBIOS BY LUIS
        bool updatehorasPlanificacion(PlanificacionDto1 componenteDto, int id);
    }
}
