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
    [Route("api/periodo")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PeriodoController : ControllerBase
    {
        private readonly IPeriodoRepository _iperiodo;
        private readonly IMapper _mapper;

        public PeriodoController(IPeriodoRepository periodorepo, IMapper mapper)
        {
            _iperiodo = periodorepo;
            _mapper = mapper;
        }

        [Route("listarPage")]
        [HttpGet]
        public async Task<ActionResult<Pager<Periodo>>> GetAllPeriodo([FromQuery] Params periodoParams)
        {
            var periodo = await _iperiodo.GetAllAsync(periodoParams.PageIndex, periodoParams.PageSize,
                                    periodoParams.Search);
            return new Pager<Periodo>(periodo.registros, periodo.totalRegistros,
            periodoParams.PageIndex, periodoParams.PageSize, periodoParams.Search);
        }

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Periodo>>> GetAllPeriodo()
        {
            var periodo = await _iperiodo.GetAllAsync();
            if (periodo == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(periodo);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<Periodo>> GetPeridobyId(int id)
        {
            var periodo = await _iperiodo.GetByIdAsync(id);
            if (periodo == null)
                return NotFound(new ApiResponse(404));
            return Ok(periodo);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<Periodo>> SavePeriodo([FromBody] PeriodoDto periododto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PeriodoDto, Periodo>();
            });
            var _mapper = new Mapper(config);
            var _periodo = _mapper.Map<Periodo>(periododto);
            _iperiodo.Add(_periodo);
            await _iperiodo.SaveAsync();
            if (periododto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            periododto.IdPeriodo = _periodo.IdPeriodo;
            return CreatedAtAction(nameof(SavePeriodo), new { IdPeriodo = periododto.IdPeriodo });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<PeriodoDto>> Put(int id, [FromBody] PeriodoDto perioddto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PeriodoDto, Periodo>();
            });
            var _mapper = new Mapper(config);

            if (perioddto == null)
                return NotFound(new ApiResponse(404, "El Periodo solicitado no existe."));

            var _period = await _iperiodo.GetByIdAsync(id);
            if (_period == null)
                return NotFound(new ApiResponse(404, "El Periodo solicitado no existe."));

            var _perioddto = _mapper.Map<Periodo>(perioddto);
            _iperiodo.Update(_perioddto);
            await _iperiodo.SaveAsync();
            return perioddto;
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _period = await _iperiodo.GetByIdAsync(id);
            if (_period == null)
                return NotFound(new ApiResponse(404, "La Carrera que solicita no existe."));

            _iperiodo.Remove(_period);
            await _iperiodo.SaveAsync();

            return NoContent();
        }
    }
}
