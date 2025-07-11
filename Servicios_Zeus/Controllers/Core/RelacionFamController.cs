using AutoMapper;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class RelacionFamController : ControllerBase
    {
        private readonly IRelacionFamRepository _relacionFam;
        private readonly IMapper _mapper;
        public RelacionFamController(IRelacionFamRepository relacionFam, IMapper mapper)
        {
            _relacionFam = relacionFam;
            _mapper = mapper;
        }
        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RelacionFam>>> GetAllRelacionFam()
        {
            var items = await _relacionFam.GetAllAsync();
            if (items == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(items);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<RelacionFam>> GetRelacionFamById(int id)
        {
            var items = await _relacionFam.GetByIdAsync(id);
            if (items == null)
                return NotFound(new ApiResponse(404));
            return Ok(items);
        }
    }
}
