using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IPaisRepository : IGenericRepository<Pai>
    {
      
        Task<List<Pai>> GetByCodPaisAsync(string cod);

    }
}
