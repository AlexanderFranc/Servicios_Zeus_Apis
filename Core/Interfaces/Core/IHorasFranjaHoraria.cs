using Core.Dtos.Core;
using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IHorasFranjaHoraria 
    {
        List<HorasFranjaHorariaDto> GetHorasFranjaHoraria(int idplanestudio);
        string EliminarHorasFranjaHoraria(int id);
    }
}
