using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IExperienciaDocenteRepository : IGenericRepository<ExperienciaDocente>
    {
        Task<List<ExperienciaDocente>> GetByIdEmpleado(int idEmpl);

        bool SaveInfoExperienciaDocente(ExperienciaDocenteDto lstExperienciaDocenteDto);

        bool EditInfoExperienciaDocente(List<ExperienciaDocenteDto> lstExperienciaDocenteDto, int idExpDoc);
    }
}
