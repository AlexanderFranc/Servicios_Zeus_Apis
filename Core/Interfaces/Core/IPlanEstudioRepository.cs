using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IPlanEstudioRepository : IGenericRepository<PlanEstudioDto>
    {
        Task<IEnumerable<PlanEstudioDto>> GetAllByIdModalidad(string codmodalidad);
        Task<List<PlanEstudio>> GetAllByIdCarrera(int id);
        Task<IdPlanMateriaDto> GetByCodeAsync(string codplan, string codmateria);
        Task<PlanEstudio> GetByMallaCarreraModalidad(int idCarrera,string codMalla,int idModalidad);

    }
}
