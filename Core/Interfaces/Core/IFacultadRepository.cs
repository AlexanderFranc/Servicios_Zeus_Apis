using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IFacultadRepository : IGenericRepository<Facultad>
    {
        Task<List<Facultad>> GetByCodeFacultadAsync(string cod);
    }
}
