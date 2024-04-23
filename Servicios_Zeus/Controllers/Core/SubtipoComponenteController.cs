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
    [Route("api/SubtipoComponente")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class SubtipoComponenteController : ControllerBase
    {
        private readonly ISubtipoComponenteRepository _isuptipocomponente;
        private readonly IMapper _mapper;
        public SubtipoComponenteController(ISubtipoComponenteRepository subtipocomponentrepo, IMapper mapper)
        {
            _isuptipocomponente = subtipocomponentrepo;
            _mapper = mapper;
        }
        [Route("GetAllPaging")]
        [HttpGet]

        public async Task<ActionResult<Pager<SubtipoComponente>>> GetAll([FromQuery] Params _params)
        {
            var subtipocomponent = await _isuptipocomponente.GetAllAsync(_params.PageIndex, _params.PageSize,
                                    _params.Search);
            return new Pager<SubtipoComponente>(subtipocomponent.registros, subtipocomponent.totalRegistros,
            _params.PageIndex, _params.PageSize, _params.Search);
        }



        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<SubtipoComponente>>> GetAll()
        {
            var subtipocomponent = await _isuptipocomponente.GetAllAsync();
            if (subtipocomponent == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(subtipocomponent);
        }
    }
}
