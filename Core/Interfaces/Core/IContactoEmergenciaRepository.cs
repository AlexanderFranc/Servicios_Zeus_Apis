using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IContactoEmergenciaRepository : IGenericRepository<ContactoEmergencium>
    {
        Task<List<ContactoEmergencium>> GetByIdEmpleado(int idEmpl);

        bool SaveContactoEmergencia(ContactoEmergencium contacto);
    }
}
