using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface ICantonRepository : IGenericRepository<Canton>
    {
        Task<List<Canton>> GetByCodCanton(string cod);
        Task<List<Canton>> GetByIdProvincia(int id);
    }
}
