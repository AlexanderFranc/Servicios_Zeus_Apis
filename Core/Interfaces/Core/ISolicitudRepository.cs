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

        
    }
}
