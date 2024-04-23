using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IUnidadEducativaRepository : IGenericRepository<UnidadEducativa>
    {
        Task<List<UnidadEducativa>> GetByTipoUnidadEdu(int tipo);
    }
}
