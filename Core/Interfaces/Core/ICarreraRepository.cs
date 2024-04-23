using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface ICarreraRepository : IGenericRepository<Carrera>
    {
        Task<List<Carrera>> GetByCodCarreraAsync(string cod);
        Task<List<Carrera>> GetByIdFacultadAsync(int id);

    }
}
