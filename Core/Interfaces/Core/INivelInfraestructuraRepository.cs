using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface INivelInfraestructuraRepository : IGenericRepository<NivelInfraestructura>
    {
        Task<List<NivelInfraestructura>> GetByIdInfraestructura(int idinfra);
    }
}
