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
    public interface IHorarioTempRepository : IGenericRepository<HorarioTemp>
    {
        bool insertHorarioSemestral(List<HorarioTempDto> horariosemestral);
        bool editHorarioSemestral(int idplanificacion, List<HorarioTempDto> horariosemestral);
    }
}
