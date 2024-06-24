using AutoMapper;
using Core.Dtos.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;
using StackExchange.Redis;

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/planificacioncruce")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PlanificacionCruceController : Controller
    {
        private readonly IPlanificacionCruceRepository _irepository;
        private readonly IMapper _mapper;

        public PlanificacionCruceController(IPlanificacionCruceRepository irepository, IMapper mapper)
        {
            _irepository = irepository;
            _mapper = mapper;
        }

        [Route("GetPlanificacionCruce/{opcion}/{idplanificacion}/{idperiodo}/{idespaciosfisicos}/{ceduladocente}")]
        [HttpGet]
        public async Task<ActionResult<List<PlanificacionCruceDto>>> GetPlanificacionCruce(string opcion,int idplanificacion, int idperiodo, int idespaciosfisicos, string ceduladocente)
        {
            var data = _irepository.GetPlanificacionCruce(opcion,idplanificacion, idperiodo, idespaciosfisicos, ceduladocente);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }
    }
}
