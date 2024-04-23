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
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/componentePlanificacion")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ComponentePlanificacionController : ControllerBase
    {
        private readonly IComponentePlanificacionRepository _iplan;
        private readonly IMapper _mapper;
        public ComponentePlanificacionController(IComponentePlanificacionRepository plan, IMapper mapper)
        {
            _iplan = plan;
            _mapper = mapper;
        }
        [Route("GetAll/{idperiodo}/{idplan}/{idmodalidad}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComponentesPlanificacionDto>>> GetAllMateriasPlanificadas(int idperiodo, int idplan, int idmodalidad)
        {
            var planestudio = _iplan.getPlanificacion(idperiodo, idplan, idmodalidad);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }
        [Route("Update/{id}")]
        [HttpPut]
        public void Put([FromBody] PlanificacionMallaDto planDto, int id)
        {
            if (planDto != null)
                _iplan.updatehorasPlanificacion(planDto, id);
        }
    }
}
