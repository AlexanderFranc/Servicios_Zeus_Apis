using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IEspaciosFisicosRepository : IGenericRepository<EspaciosFisico>
    {
        Task<List<EspaciosFisico>> GetByCodEspaciosFiscAsync(string cod);

        Task<List<EspaciosFisico>> GetByIdNivel(int idnivel);
    }
}
