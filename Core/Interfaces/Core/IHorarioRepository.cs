using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IHorarioRepository : IGenericRepository<HorarioFecha>
    {
        Task<IEnumerable<HorarioFecha>> GetAll(int idplanestudio,int idperiodo,int idmodalidad,string dniprofesor,int idtipocomponente,string paralelo,int idespaciofisico,int idmateria);
        bool insertHorarioModular(int idplanificacion,List<HorarioModularDto> horariomodular);
        bool insertHorarioSemestral(int idplanificacion, List<HorarioDto> horariosemestral);
        List<HorarioModularDto> GetHorarioFechasPlanificado(int idplanificacion);
        List<HorarioModularDto> GetHorarioModularPlanificado(int idplanificacion);

        bool delete(HorarioModularDto item);

    }
}
