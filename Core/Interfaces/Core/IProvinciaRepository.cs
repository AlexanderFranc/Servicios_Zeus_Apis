using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IProvinciaRepository : IGenericRepository<Provincium>
    {
        Task<List<Provincium>> GetByIdPaisAsync(int id);
        Task<List<Provincium>> GetByCodProvincia(string cod);
        Task<List<Provincium>> GetAllByProvincia();
    }
}
