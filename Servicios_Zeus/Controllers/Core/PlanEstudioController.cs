using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Servicios_Zeus.Helpers.Errors;
using Servicios_Zeus.Helpers;
using Core.Dtos.Core;
using AutoMapper;
using Infraestructure.Mappers;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
namespace Servicios_Zeus.Controllers.Core
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/PlanEstudio")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public class PlanEstudioController : ControllerBase
    {
        private readonly IPlanEstudioRepository _iplan;
        private readonly IMapper _mapper;
        public PlanEstudioController(IPlanEstudioRepository plan, IMapper mapper)
        {
            _iplan = plan;
            _mapper = mapper;
        }


        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanEstudioDto>>> GetAll()
        {
            var planestudio = await _iplan.GetAllAsync();
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }

        [Route("GetAllByIdModalidad/{id}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanEstudioDto>>> GetAllByIdModalidad(string id)
        {
            var planestudio = await _iplan.GetAllByIdModalidad(id);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }

        [Route("GetAllByIdCarrera/{id}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanEstudioDto>>> GetAllByIdCarrera(int id)
        {
            var planestudio = await _iplan.GetAllByIdCarrera(id);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }
        [Route("GetAllByPlanMateria/{codplan}/{codmateria}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanEstudioDto>>> GetByCodeAsync(string codplan, string codmateria)
        {
            var planestudio = await _iplan.GetByCodeAsync(codplan, codmateria);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(planestudio);
        }

        [Route("GetByMallaCarreraModalidad/{idCarrera}/{codMalla}/{idModalidad}")]
        [HttpGet]
        public async Task<ActionResult<PlanEstudioDto>> GetByMallaCarreraModalidad(int idCarrera, string codMalla, int idModalidad)
        {
            var planestudio = await _iplan.GetByMallaCarreraModalidad(idCarrera, codMalla, idModalidad);
            if (planestudio == null)
                return NotFound(new ApiResponse(404, "No se encuentra el recurso solicitado."));
            return Ok(planestudio);
        }

    }

}
