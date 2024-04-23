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
    [Route("api/malla")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class MallaController : ControllerBase
    {
        private readonly IMallaRepository _imalla;
        private readonly IMapper _mapper;
        public MallaController(IMallaRepository mallarepo, IMapper mapper)
        {
            _imalla = mallarepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]

        public async Task<ActionResult<Pager<Malla>>> GetAllMalla([FromQuery] Params mallaParams)
        {
            var malla = await _imalla.GetAllAsync(mallaParams.PageIndex, mallaParams.PageSize,
                                    mallaParams.Search);
            return new Pager<Malla>(malla.registros, malla.totalRegistros,
            mallaParams.PageIndex, mallaParams.PageSize, mallaParams.Search);
        }
        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<MallaMateriaDto>>> GetAllMalla()
        {
            var malla = await _imalla.getMalla();
            if (malla == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(malla);
        }

        [Route("GetByIdPlanEstudio/{id}/{idmodalidad}")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<MallaMateriaDto>>> GetByIdPlanEstudio(string id,int idmodalidad)
        {
            var malla = await _imalla.GetByIdPlanEstudio(id,idmodalidad);
            if (malla == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(malla);
        }


        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Malla>> GetMallabyId(int id)
        {
            var malla = await _imalla.GetByIdAsync(id);
            if (malla == null)
                return NotFound(new ApiResponse(404));
            return Ok(malla);
        }


        [Route("GetByCod/{codmalla}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Malla>>> GetPaisbyCod(int codmalla)
        {
            var malla = await _imalla.GetByCodMallaAsync(codmalla);
            if (malla == null)
                return NotFound(new ApiResponse(404));
            return Ok(malla);
        }
        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Pai>> SaveMalla([FromBody] MallaDto malladto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MallaDto, Malla>();
            });
            var _mapper = new Mapper(config);
            var _malla = _mapper.Map<Malla>(malladto);
            _imalla.Add(_malla);
            await _imalla.SaveAsync();
            if (malladto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            malladto.IdMalla = _malla.IdMalla;
            return CreatedAtAction(nameof(SaveMalla), new { IdPais = malladto.IdMalla });

        }
        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<MallaDto>> Put(int id, [FromBody] MallaDto malladto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MallaDto, Malla>();
            });
            var _mapper = new Mapper(config);

            if (malladto == null)
                return NotFound(new ApiResponse(404, "La malla solicitado no existe."));

            var _malla = await _imalla.GetByIdAsync(id);
            if (_malla == null)
                return NotFound(new ApiResponse(404, "El país solicitado no existe."));

            var _malladto = _mapper.Map<Malla>(malladto);
            _imalla.Update(_malladto);
            await _imalla.SaveAsync();
            return malladto;
        }

        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var malla = await _imalla.GetByIdAsync(id);
            if (malla == null)
                return NotFound(new ApiResponse(404, "la Malla que solicita no existe."));

            _imalla.Remove(malla);
            await _imalla.SaveAsync();

            return NoContent();
        }
    }
}
