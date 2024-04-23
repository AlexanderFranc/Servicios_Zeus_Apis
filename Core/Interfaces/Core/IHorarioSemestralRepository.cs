using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IHorarioSemestralRepository : IGenericRepository<HorarioSemestralDto>
    {
        List<HorarioSemestralDto> GetHorariosPlanificacionSemestral(string tipohorario, int idplanestudio, int? idplanificacion, int idperiodo, int idperiodicidad, int idmateria, int idsubtipocomponente, int idespacio, string ceduladocente);
        string DeleteHorarioSemestralPlanificado(int idplanidicacion, int dia, string horaI, string horaF);

    }
}
