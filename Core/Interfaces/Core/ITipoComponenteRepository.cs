using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface ITipoComponenteRepository : IGenericRepository<TipoComponente>
    {
        
        Task<List<TipoComponente>> GetByCodeTipoComponenteAsync(string cod);
        Task<IEnumerable<TipoComponenteSubtipoDto>> TipoSubtipoCoponente();

    }
}
