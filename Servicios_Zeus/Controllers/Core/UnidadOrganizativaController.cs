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
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/unidad-organizativa")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class UnidadOrganizativaController : ControllerBase
    {
        private readonly IUnidadOrganizativaRepository _iunidadOrg;
        private readonly IMapper _mapper;

        public UnidadOrganizativaController(IUnidadOrganizativaRepository unidadorgrepo, IMapper mapper)
        {
            _iunidadOrg = unidadorgrepo;
            _mapper = mapper;
        }

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadOrganizativa>>> GetAllUnidadOrganizativa()
        {
            var unidadOrg = await _iunidadOrg.GetAllAsync();
            if (unidadOrg == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(unidadOrg);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<UnidadOrganizativa>> GetUnidadOrganizativabyId(int id)
        {
            var unidadOrg = await _iunidadOrg.GetByIdAsync(id);
            if (unidadOrg == null)
                return NotFound(new ApiResponse(404));
            return Ok(unidadOrg);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<UnidadOrganizativa>> SaveUnidadOrganizativa([FromBody] UnidadOrganizativaDto unidadorgdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnidadOrganizativaDto, UnidadOrganizativa>();
            });
            var _mapper = new Mapper(config);
            var _unidadorg = _mapper.Map<UnidadOrganizativa>(unidadorgdto);
            _iunidadOrg.Add(_unidadorg);
            await _iunidadOrg.SaveAsync();
            if (unidadorgdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            unidadorgdto.IdUo = _unidadorg.IdUo;
            return CreatedAtAction(nameof(SaveUnidadOrganizativa), new { IdUo = unidadorgdto.IdUo });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<UnidadOrganizativaDto>> Put(int id, [FromBody] UnidadOrganizativaDto unidadorgdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnidadOrganizativaDto, UnidadOrganizativa>();
            });
            var _mapper = new Mapper(config);

            if (unidadorgdto == null)
                return NotFound(new ApiResponse(404, "La Unidad Organizativa solicitado no existe."));

            var _unidadorg = await _iunidadOrg.GetByIdAsync(id);
            if (_unidadorg == null)
                return NotFound(new ApiResponse(404, "La Unidad Organizativa solicitado no existe."));

            var _unidadorgdto = _mapper.Map<UnidadOrganizativa>(unidadorgdto);
            _iunidadOrg.Update(_unidadorgdto);
            await _iunidadOrg.SaveAsync();
            return unidadorgdto;
        }
    }
}
