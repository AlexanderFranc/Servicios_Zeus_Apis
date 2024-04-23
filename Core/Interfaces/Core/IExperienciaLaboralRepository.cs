using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IExperienciaLaboralRepository :  IGenericRepository<ExperienciaLaboral>
    {
        Task<List<ExperienciaLaboral>> GetByIdEmpleado(int idEmpl);
        bool SaveInfoExperienciaLaboral(ExperienciaLaboralDto lstExperienciaLaboralDto);

        bool EditInfoExperienciaLaboral(List<ExperienciaLaboralDto> lstExperienciaLaboralDto, int idExpLab);
    }
}
