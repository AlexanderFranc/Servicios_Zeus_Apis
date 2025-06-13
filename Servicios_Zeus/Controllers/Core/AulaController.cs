using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class AulaController : ControllerBase
    {
        private readonly IAulaRepository _iAulaRepository;
        public AulaController(IAulaRepository ihoras)
        {
            _iAulaRepository = ihoras;
        }
        [Route("ocupacion-planificacion-semestral/{idperiodo}/{idespacio}")]
        [HttpGet]
        public async Task<ActionResult<List<HorarioSemestralDto>>> GetOcupacionPlanificacionSemestral(int idperiodo, int idespacio)
        {
            var data = _iAulaRepository.GetOcupacionPlanificacionSemestral(idperiodo, idespacio);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }
    }
}
