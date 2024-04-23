using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface ICapacitacionRepository : IGenericRepository<Capacitacion>
    {
        Task<List<Capacitacion>> GetByIdEmpleado(int idEmpl);
        bool SaveCapacitaciones(CapacitacionDto lstCapacitacionDto);
        bool EditCapacitaciones(CapacitacionDto lstCapacitacionDto, int idCapacitacion);
    }
}