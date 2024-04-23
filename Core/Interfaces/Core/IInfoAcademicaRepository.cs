using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IInfoAcademicaRepository : IGenericRepository<InfoAcademica>
    {
        Task<List<InfoAcademica>> GetByIdEmpleado(int idEmpl);

        bool  SaveInfoAcademico(List<InfoAcademicaDto> lstInfoAcademicoDto);

        bool EditInfoAcademico(List<InfoAcademicaDto> lstInfoAcademicoDto, int idInfoAcad);
    }
}
