using Core.Dtos.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IPlanificacionRepository: IGenericRepository<ComponentesPlanificacionDto>
    {
        List<ComponentesPlanificacionDto> getPlanificacion(int idperiodo, int idplanestudio, int idmodalidadplanificacio);
        bool updatehorasPlanificacion(PlanificacionMallaDto componenteDto,int id);

        bool savePlanificacion(PlanificacionMallaDto planificacionDto);

    }
}
