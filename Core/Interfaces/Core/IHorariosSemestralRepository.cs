using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IHorariosSemestralRepository : IGenericRepository<HorarioDto>
    {
        Task<IEnumerable<HorarioDto>> GetByPlanificacionAsync(int id);
    }
}
