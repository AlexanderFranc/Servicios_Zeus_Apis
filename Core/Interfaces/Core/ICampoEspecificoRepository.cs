using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface ICampoEspecificoRepository : IGenericRepository<CampoEspecifico>
    {
        Task<List<CampoEspecifico>> GetByCampoAmplio(int idcamA);
    }
}
