using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IEmpleadoTempArchivoRepository : IGenericRepository<EmpleadoTempArchivo>
    {
        Task<List<EmpleadoTempArchivo>> GetfindByIdEmpN(int idEmpl);

        Task<EmpleadoTempArchivo> GetfindEmpArch(int idEmpl,int idTipoArchivo,bool seguimiento);

        bool SaveEmpleadoTempArchivo(EmpleadoTempArchivoDto emplTempArchivoDto);
    }
}
