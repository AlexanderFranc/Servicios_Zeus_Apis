using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IHorariosPlanificacionRepository : IGenericRepository<HorariosPlanificacionDto>
    {
        //'S',10,4,420,1,68,'1707833354','2023-06-04','2023-07-11'
        List<HorariosPlanificacionDto> GetHorariosPlanificacionSemanal(string opcion, int idperiodo, int id_periodicidadplanificacion, int idmateria, int idtipocomponente, int idespaciosfisicos,string codprofe,string fechaPlanificarIni,string fechaPlanificarFin);
        string GetDescripcionCruce(string id);



    }
}
