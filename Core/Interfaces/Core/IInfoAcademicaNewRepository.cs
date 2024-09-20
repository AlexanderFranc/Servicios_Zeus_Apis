using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public  interface IInfoAcademicaNewRepository : IGenericRepository<InfoAcademicaNew>
    {
        Task<List<InfoAcademicaNew>> GetByIdEmpleado(int idEmpl);

        bool SaveInfoAcademico(InfoAcademicaNewDto lstInfoAcademicoDto);

        bool EditInfoAcademico(List<InfoAcademicaNewDto> lstInfoAcademicoDto, int idInfoAcad);

        Task<List<InfoAcademicaNewDto>> GetTitulosEmpleado(string identificacion);
    }
}
