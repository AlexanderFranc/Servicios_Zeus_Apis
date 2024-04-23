using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public  interface IParroquiaRepository : IGenericRepository<Parroquium>
    {
        Task<List<Parroquium>> GetByIdCantonAsync(int id);
        Task<List<Parroquium>> GetByCodParroquia(string cod);
    }
}
