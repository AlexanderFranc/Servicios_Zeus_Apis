using Core.Dtos.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Http;
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
    public class AprobadorPlanAnaliticoController : ControllerBase
    {
        private readonly IAprobadorPlanAnaliticoRepository _irepositoty;
        public AprobadorPlanAnaliticoController(IAprobadorPlanAnaliticoRepository irepositoty)
        {
            _irepositoty = irepositoty;
        }
        [Route("getAll")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<PlanAnaliticoAprobadorDto>>> getAll([FromBody] List<PlanAnaliticoDto> planAnaliticolst)
        {
            var data = await _irepositoty.GetAprobadorPlanAnalitico(planAnaliticolst);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }
    }
}
