using Core.Dtos.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IAulaRepository : IGenericRepository<HorarioSemestralDto>
    {
        List<HorarioSemestralDto> GetOcupacionPlanificacionSemestral(int idperiodo, int idespacio);

        List<AulasDto> GetAulas(int activo);
    }
}
