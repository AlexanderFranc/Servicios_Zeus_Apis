using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IEmpleadoRepository : IGenericRepository<Empleado>
    {
        Task<Empleado> GetByDniAsync(string ced);
        Task<Empleado> GetByCedulaAsync(string ced);
        List<EmpleadoDto> GetAllEmpleado();
        Task<IEnumerable<Empleado>> getDocentesPlanificacion();
        Task<IEnumerable<Empleado>> getDocentesPlanificacionByFacu(int id);
        Task<IEnumerable<Empleado>> getDocentesPlanificacionByCarr(int id);

        Task<List<EmpleadoDto>> GetEmployees(); 
        Task<List<EmpleadoDto>> ListarEmpleadosInactivos(); 

    }
}
