using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface ITipoMateriaCatalogoRepository : IGenericRepository<TipoMateriaCatalogo>
    {    
        Task<List<TipoMateriaCatalogo>> GetByNameTipoMateriaCatalogoAsync(string cod);
    }
}
