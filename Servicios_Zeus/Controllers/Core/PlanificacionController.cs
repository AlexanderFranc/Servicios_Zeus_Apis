using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/planificacion")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PlanificacionController : ControllerBase
    {
        private readonly IPlanificacionRepository _iplan;
        private readonly IMapper _mapper;
        public PlanificacionController(IPlanificacionRepository plan, IMapper mapper)
        {
            _iplan = plan;
            _mapper = mapper;
        }
        [Route("GetAll/{idperiodo}/{idplan}/{idmodalidad}")]
        [HttpGet]
        public  async Task<ActionResult<IEnumerable<ComponentesPlanificacionDto>>> GetAll(int idperiodo,int idplan,int idmodalidad)
        {
            var planestudio =  _iplan.getPlanificacion(idperiodo,idplan,idmodalidad);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }
        [Route("GetById/{idPlanificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComponentesPlanificacionDto>>> GetById(int idPlanificacion)
        {
            var planestudio = _iplan.getById(idPlanificacion);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }
        [Route("Update/{id}")]
        [HttpPut]
        public void Put([FromBody] PlanificacionMallaDto planDto,int id)
        {
            if (planDto != null)
                _iplan.updatehorasPlanificacion(planDto,id);
        }

        [Route("Save")]
        [HttpPost]
        public void save([FromBody] PlanificacionMallaDto planDto)
        {
            if (planDto != null)
                _iplan.savePlanificacion(planDto);
        }
        /// <summary>
        /// Verifica si se debe validar las horas a planificar en el registro de planificación
        /// </summary>
        /// <param name="codPeriodo"></param>
        /// <param name="codPlan"></param>
        /// <param name="idModalidad"></param>
        /// <param name="codMateria"></param>
        /// <returns>true si debe ser validado, false no debe ser validado</returns>
        [Route("ValidarMateria/{codPeriodo}/{codPlan}/{idModalidad}/{codMateria}")]
        [HttpGet]
        public async Task<ActionResult<bool>> ValidarMateria(string codPeriodo, string codPlan, int idModalidad, string codMateria)
        {
            var validar = _iplan.validarMateria(codPeriodo, codPlan, idModalidad, codMateria);
            return Ok(!validar);
        }
        [Route("ObtenerPlanificacionTH/{idperiodo}/{idFacultad}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComponentesPlanificacionDto>>> ObtenerPlanificacionTH(int idperiodo, int idFacultad)
        {
            var planestudio = _iplan.obtenerPlanificacionTH(idperiodo, idFacultad);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }



        [Route("UpdateFechas/{id}")]
        [HttpPut]
        public void PutFechas([FromBody] FechasPlanificacionDto fehas, int id)
        {
            if (fehas != null)
                _iplan.updateFcehas(fehas, id);
        }
        [Route("obtenerFechasPlanificacion/{idplanificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FechasPlanificacionDto>>> obtenerFechasPlanificacion(int idplanificacion)
        {
            var planestudio = _iplan.obtenerFechasPlanificacion(idplanificacion);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }
    }
}
