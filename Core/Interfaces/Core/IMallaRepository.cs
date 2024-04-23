using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IMallaRepository : IGenericRepository<Malla>
    {
      
        Task<List<Malla>> GetByCodMallaAsync(int cod);
        Task<ICollection<MallaMateriaDto>> getMalla();

        Task<ICollection<MallaMateriaDto>> GetByIdPlanEstudio(string id, int idmodalidad);
        
    }
}
