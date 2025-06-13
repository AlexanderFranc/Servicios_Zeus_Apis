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
    public interface ISolicitudRepository : IGenericRepository<Solicitud>
    {
        //List<SolicitudPlanificacionDto> getSolicitudes(string opcion, string tipo,string periodo, string codfac, string codcar, string estado);
        List<SolicitudPlanificacionDto> getSolicitudPlanificacion(int idperiodo, int idplanestudio, int idmodalidadplanificacio);

        List<SolicitudPlanificacionDto> getSolicitudPlanificacionVice(int idperiodo, int idfacultad, int idcarrera, string estado);

        List<HorarioSemestralDto> GetHorarioSolicitud(string tipohorario, int idplanestudio, int? idSolicitud, int idperiodo, int idperiodicidad, int idmateria, int idsubtipocomponente, int idespacio, string ceduladocente);

        List<SolicitudEmpleadoDto> getSolicitudNuevoEmp(int idperiodo, int idfacultad, string estado);
        List<SolicitudPlanificacionDto> getSolicitudPlanificacionNuevoEmp(int idEmpleadoN);
        List<EmpleadoTempNuevoDto> getNuevoEmp(int idEmpleadoN);
        List<SolicitudPlanificacionDto> getSolicitudPlanificacionTH(int idperiodo, int idfacultad, string estado);
        List<EmpNuevoObservacionLogDto> getLogObservacionesSolicitudNEmp(int idEmpNuevo);
        bool EditSolicitudEstado(SolicitudDto solicitudDto, int idSolicitud);
        bool EditSolicitudEmpleadoEstado(SolicitudEmpleadoDto solicitudEmpleadoDto, int idEmpleadoN);
        bool SaveSolicitudPlanEmp(List<SolicitudDto> solicitudDto, int idEmpleadoNuevo);
        bool EditSolicitud(SolicitudDto solicitudDto);

    }
}
