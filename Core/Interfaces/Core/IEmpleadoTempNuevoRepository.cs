using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IEmpleadoTempNuevoRepository : IGenericRepository<EmpleadoTempNuevo>
    {
        bool SaveIdiomas(IdiomaDto lstIdiomaDto);
    }
}
