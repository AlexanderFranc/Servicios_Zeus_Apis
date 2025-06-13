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
    public interface IHorarioFechaTempRepository : IGenericRepository<HorarioFechaTemp>
    {
        bool insertHorarioModularTemp(int idplanificacion, List<HorarioModularDto> horariomodular);
        List<HorarioModularDto> GetHorarioFechasPlanificadoTemp(int idplanificacion);
        bool delete(HorarioFechaTempDto item);

    }
}
