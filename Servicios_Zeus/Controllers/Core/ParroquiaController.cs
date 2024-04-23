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
    [Route("api/parroquia")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ParroquiaController : ControllerBase
    {
        private readonly IParroquiaRepository _iparroquia;
        private readonly IMapper _mapper;

        public ParroquiaController(IParroquiaRepository parroquiarepo, IMapper mapper)
        {
            _iparroquia = parroquiarepo;
            _mapper = mapper;
        }

        //[Route("listarPage")]
        //[HttpGet]
        //public async Task<ActionResult<Pager<Parroquium>>> GetAllParroquias([FromQuery] Params parroquiaParams)
        //{
        //    var parroquia = await _iparroquia.GetAllAsync(parroquiaParams.PageIndex, parroquiaParams.PageSize,
        //                            parroquiaParams.Search);
        //    return new Pager<Parroquium>(parroquia.registros, parroquia.totalRegistros,
        //    parroquiaParams.PageIndex, parroquiaParams.PageSize, parroquiaParams.Search);
        //}

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parroquium>>> GetAllParroquia()
        {
            var parroquia = await _iparroquia.GetAllAsync();
            if (parroquia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(parroquia);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<Parroquium>> GetParroquiaById(int id)
        {
            var parroquia = await _iparroquia.GetByIdAsync(id);
            if (parroquia == null)
                return NotFound(new ApiResponse(404));
            return Ok(parroquia);
        }

        [Route("GetByIdCanton/{id}")]
        [HttpGet]
        public async Task<ActionResult<Parroquium>> GetByIdCanton(int id)
        {
            var parroquia = await _iparroquia.GetByIdCantonAsync(id);
            if (parroquia == null)
                return NotFound(new ApiResponse(404));
            return Ok(parroquia);
        }

        [Route("GetByCodParroquia/{cod}")]
        [HttpGet]
        public async Task<ActionResult<Parroquium>> GetByCodParroquia(string cod)
        {
            var parroquia = await _iparroquia.GetByCodParroquia(cod);
            if (parroquia == null)
                return NotFound(new ApiResponse(404));
            return Ok(parroquia);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<Parroquium>> SaveParroquia([FromBody] ParroquiaDto parroquiadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ParroquiaDto, Parroquium>();
            });
            var _mapper = new Mapper(config);
            var _parroquia = _mapper.Map<Parroquium>(parroquiadto);
            _iparroquia.Add(_parroquia);
            await _iparroquia.SaveAsync();
            if (parroquiadto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            parroquiadto.IdParroquia = _parroquia.IdParroquia;
            return CreatedAtAction(nameof(SaveParroquia), new { IdParroquia = parroquiadto.IdParroquia });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<ParroquiaDto>> Put(int id, [FromBody] ParroquiaDto parroquiadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ParroquiaDto, Parroquium>();
            });
            var _mapper = new Mapper(config);

            if (parroquiadto == null)
                return NotFound(new ApiResponse(404, "La Parroquia solicitado no existe."));

            var _parroquia = await _iparroquia.GetByIdAsync(id);
            if (_parroquia == null)
                return NotFound(new ApiResponse(404, "La Parroquia solicitado no existe."));

            var _parroquiadto = _mapper.Map<Parroquium>(parroquiadto);
            _iparroquia.Update(_parroquiadto);
            await _iparroquia.SaveAsync();
            return parroquiadto;
        }
    }
}
