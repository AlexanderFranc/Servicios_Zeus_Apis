using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class PlanificacionRepository1 : GenericCoreRepository<Planificacion>, IPlanificacionRepository1
    {
        public PlanificacionRepository1(ZeusCoreContext context) : base(context)
        {
        }
        //CAMBIOS BY LUIS
        public bool updatehorasPlanificacion(PlanificacionDto1 componenteDto, int idplanificacion)
        {
            bool result = Conexion.ActualizarZeus("PLANIFICACION",
                "ID_MALLA=" + componenteDto.IdMalla + "," +
                //"ID_MATERIA=" + componenteDto.IdMateria + "," +
                //"ID_NIVEL_ESTUDIO=" + componenteDto.IdNivelEstudio + "," +
                //"ID_PLAN_ESTUDIO=" + componenteDto.IdPlanEstudio + "," +
                "ID_PERIODO=" + componenteDto.IdPeriodo + "," +
                //"ID_PERIODICIDAD=" + componenteDto.IdPeriodicidad + "," +
                //"ID_TIPO_PERIODO=" + componenteDto.IdTipoPeriodo + "," +
                //"ID_MODALIDAD=" + componenteDto.IdModalidad + "," +
                //"ID_ESTADO_PERIODO=" + componenteDto.IdEstadoPeriodo + "," +
                "ID_MODALIDAD_PLANIFICACION=" + componenteDto.IdModalidadPlanificacion + "," +
                "ID_PERIODICIDAD_PLANIFICACION=" + componenteDto.IdPeriodicidadPlanificacion + "," +
                "DNI_PROFESORC='" + componenteDto.DniProfesorc + "'," +
                "ID_TIPO_COMPONENTE=" + componenteDto.IdTipoComponente + "," +
                "PARALELO='" + componenteDto.Paralelo + "'," +
                "ID_ESPACIOS_FISICOS=" + componenteDto.IdEspaciosFisicos + "," +
                "CUPO=" + componenteDto.Cupo
                , " WHERE ID_PLANIFICACION=" + idplanificacion);
            return result;
        }

    }
}
