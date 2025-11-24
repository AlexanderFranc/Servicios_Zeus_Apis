using Core.Dtos.Core;
using Core.Interfaces.Generico;
using Microsoft.AspNetCore.Mvc;
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
        ComponentesPlanificacionDto getById(int idPlanificacion);
        bool updatehorasPlanificacion(PlanificacionMallaDto componenteDto,int id);

        bool savePlanificacion(PlanificacionMallaDto planificacionDto);

        bool validarMateria(string codPeriodo, string codPlan, int idModalidad, string codMateria);
        List<ComponentesPlanificacionDto> obtenerPlanificacionTH(int idperiodo, int idFacultad);
        List<FechasPlanificacionDto> obtenerFechasPlanificacion(int idplanificacion);

        bool updateFcehas(FechasPlanificacionDto fechas, int id);

        ResponseDto DeletePlanificacion(int idplanidicacion);

        List<ComponentesPlanificacionDto> getPlanificacionSimultaneo(int idperiodo, int idfacultad, int idcarrera,int profesors, int idplanestudio, int idmodalidadplanificacio);

        List<ReportePlanificacionDto> getReportePlanificacion(int idperiodo, int idfacultad, int idcarrera, int idplanestudio, string tipoPlanificacion);
    }
}
