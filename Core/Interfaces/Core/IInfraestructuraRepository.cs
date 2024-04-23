using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IInfraestructuraRepository : IGenericRepository<Infraestructura>
    {
        Task<List<Infraestructura>> GetByCodInfraestructuraAsync(string cod);

        Task<List<Infraestructura>> GetByTipoInfraAsync(int idtipo);

        Task<List<Infraestructura>> GetAllByInfraestructuraAsync();
    }
}
