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
    [Route("api/espacios-fisicos")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class EspaciosFisicosController : ControllerBase
    {
        private readonly IEspaciosFisicosRepository _iespaciofisc;
        private readonly IMapper _mapper;

        public EspaciosFisicosController(IEspaciosFisicosRepository espaciofiscrepo, IMapper mapper)
        {
            _iespaciofisc = espaciofiscrepo;
            _mapper = mapper;
        }

        [Route("listarPage")]
        [HttpGet]
        public async Task<ActionResult<Pager<EspaciosFisico>>> GetAllEspaciosFisicos([FromQuery] Params espaciofisParams)
        {
            var espaciofis = await _iespaciofisc.GetAllAsync(espaciofisParams.PageIndex, espaciofisParams.PageSize,
                                    espaciofisParams.Search);
            return new Pager<EspaciosFisico>(espaciofis.registros, espaciofis.totalRegistros,
            espaciofisParams.PageIndex, espaciofisParams.PageSize, espaciofisParams.Search);
        }

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspaciosFisico>>> GetAllEspacioFisico()
        {
            var espaciofis = await _iespaciofisc.GetAllAsync();
            if (espaciofis == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(espaciofis);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<EspaciosFisico>> GetEspaciosFisicosbyId(int id)
        {
            var espaciofis = await _iespaciofisc.GetByIdAsync(id);
            if (espaciofis == null)
                return NotFound(new ApiResponse(404));
            return Ok(espaciofis);
        }

        [Route("findByIdINivel/{id}")]
        [HttpGet]
        public async Task<ActionResult<EspaciosFisico>> GetfindByIdNivel(int id)
        {
            var espaciofis = await _iespaciofisc.GetByIdNivel(id);
            if (espaciofis == null)
                return NotFound(new ApiResponse(404));
            return Ok(espaciofis);
        }
        [Route("findByCod/{cod}")]
        [HttpGet]
        public async Task<ActionResult<EspaciosFisico>> GetfindByCod(string cod)
        {
            var espaciofis = await _iespaciofisc.GetByCodEspaciosFiscAsync(cod);
            if (espaciofis == null)
                return NotFound(new ApiResponse(404));
            return Ok(espaciofis);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<EspaciosFisico>> SaveEspaciosFisicos([FromBody] EspaciosFisicosDto espaciofisdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var _mapper = new Mapper(config);
            var _espaciofis = _mapper.Map<EspaciosFisico>(espaciofisdto);
            _iespaciofisc.Add(_espaciofis);
            await _iespaciofisc.SaveAsync();
            if (espaciofisdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            espaciofisdto.IdEspaciosFisicos = _espaciofis.IdEspaciosFisicos;
            return CreatedAtAction(nameof(SaveEspaciosFisicos), new { IdEspaciosFisicos = espaciofisdto.IdEspaciosFisicos });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<EspaciosFisicosDto>> Put(int id, [FromBody] EspaciosFisicosDto espaciofisdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var _mapper = new Mapper(config);

            if (espaciofisdto == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));

            var _espaciofis = await _iespaciofisc.GetByIdAsync(id);
            if (_espaciofis == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));

            var _espaciofisdto = _mapper.Map<EspaciosFisico>(espaciofisdto);
            _iespaciofisc.Update(_espaciofisdto);
            await _iespaciofisc.SaveAsync();
            return espaciofisdto;
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _espaciofis = await _iespaciofisc.GetByIdAsync(id);
            if (_espaciofis == null)
                return NotFound(new ApiResponse(404, "La Carrera que solicita no existe."));

            _iespaciofisc.Remove(_espaciofis);
            await _iespaciofisc.SaveAsync();

            return NoContent();
        }
    }
}
