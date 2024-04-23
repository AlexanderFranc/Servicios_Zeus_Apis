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
    [Route("api/canton")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class CantonController : ControllerBase
    {
        private readonly ICantonRepository _icanton;
        private readonly IMapper _mapper;

        public CantonController(ICantonRepository cantonrepo, IMapper mapper)
        {
            _icanton = cantonrepo;
            _mapper = mapper;
        }

        //[Route("listarPage")]
        //[HttpGet]
        //public async Task<ActionResult<Pager<Canton>>> GetAllCantones([FromQuery] Params cantonParams)
        //{
        //    var canton = await _icanton.GetAllAsync(cantonParams.PageIndex, cantonParams.PageSize,
        //                            cantonParams.Search);
        //    return new Pager<Canton>(canton.registros, canton.totalRegistros,
        //    cantonParams.PageIndex, cantonParams.PageSize, cantonParams.Search);
        //}

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Canton>>> GetAllCanton()
        {
            var canton = await _icanton.GetAllAsync();
            if (canton == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(canton);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<Canton>> GetCantonbyId(int id)
        {
            var canton = await _icanton.GetByIdAsync(id);
            if (canton == null)
                return NotFound(new ApiResponse(404));
            return Ok(canton);
        }

        [Route("GetByIdProvincia/{id}")]
        [HttpGet]
        public async Task<ActionResult<Canton>> GetByIdPais(int id)
        {
            var canton = await _icanton.GetByIdProvincia(id);
            if (canton == null)
                return NotFound(new ApiResponse(404));
            return Ok(canton);
        }

        [Route("GetByCodCanton/{cod}")]
        [HttpGet]
        public async Task<ActionResult<Provincium>> GetAllByCodCanton(string cod)
        {
            var canton = await _icanton.GetByCodCanton(cod);
            if (canton == null)
                return NotFound(new ApiResponse(404));
            return Ok(canton);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<Canton>> SaveCanton([FromBody] CantonDto cantondto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CantonDto, Canton>();
            });
            var _mapper = new Mapper(config);
            var _canton = _mapper.Map<Canton>(cantondto);
            _icanton.Add(_canton);
            await _icanton.SaveAsync();
            if (cantondto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            cantondto.IdCanton = _canton.IdCanton;
            return CreatedAtAction(nameof(SaveCanton), new { IdCanton = cantondto.IdCanton });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<CantonDto>> Put(int id, [FromBody] CantonDto cantondto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CantonDto, Canton>();
            });
            var _mapper = new Mapper(config);

            if (cantondto == null)
                return NotFound(new ApiResponse(404, "La Canton solicitado no existe."));

            var _canton = await _icanton.GetByIdAsync(id);
            if (_canton == null)
                return NotFound(new ApiResponse(404, "La Canton solicitado no existe."));

            var _cantondto = _mapper.Map<Canton>(cantondto);
            _icanton.Update(_cantondto);
            await _icanton.SaveAsync();
            return cantondto;
        }
    }
}
