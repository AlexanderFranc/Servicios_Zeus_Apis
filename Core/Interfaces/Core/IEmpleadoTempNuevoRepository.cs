using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IEmpleadoTempNuevoRepository : IGenericRepository<EmpleadoTempNuevo>
    {

        bool EditEmpleadoTempNuevo(EmpleadoTempNuevoDto empleadoTempNuevoDto, int idEmpleadoNuevo);

        bool ExisteEmpleadoTemp(string identificacion);
    }
}
