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
    [Route("api/planificacionComponent")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PlanificacionComponentController : ControllerBase
    {
        private readonly IPlanificacionComponentRepository _iplan;
        private readonly IMapper _mapper;
        public PlanificacionComponentController(IPlanificacionComponentRepository plan, IMapper mapper)
        {
            _iplan = plan;
            _mapper = mapper;
        }
        [Route("GetById/{id}")]
        [HttpGet]
        public  async Task<ActionResult<Planificacion>> GetById(int id)
        {
            var planestudio = await _iplan.GetByIdAsync(id);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }


    }
}
