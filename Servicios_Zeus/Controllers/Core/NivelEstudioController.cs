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
    [Route("api/NivelEstudio")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class NivelEstudioController : ControllerBase
    {
        private readonly INivelEstudioRepository _iniveles;
        private readonly IMapper _mapper;
        public NivelEstudioController(INivelEstudioRepository niveles, IMapper mapper)
        {
            _iniveles = niveles;
            _mapper = mapper;
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelEstudio>>> GetAll()
        {
            var estadope = await _iniveles.GetAllAsync();
            if (estadope == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(estadope);
        }
    }
}
