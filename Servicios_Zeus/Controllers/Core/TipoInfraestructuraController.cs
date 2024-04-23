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
    [Route("api/tipo-infraestructura")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoInfraestructuraController : ControllerBase
    {
        private readonly ITipoInfraestructuraRepository _itipoinfra;
        private readonly IMapper _mapper;

        public TipoInfraestructuraController(ITipoInfraestructuraRepository tipoInfrarepo, IMapper mapper)
        {
            _itipoinfra = tipoInfrarepo;
            _mapper = mapper;
        }


        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoInfraestructura>>> GetAllTipoInfraestructura()
        {
            var tipoInfra = await _itipoinfra.GetAllAsync();
            if (tipoInfra == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoInfra);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoInfraestructura>> GetTipoInfraestructurabyId(int id)
        {
            var tipoInfra = await _itipoinfra.GetByIdAsync(id);
            if (tipoInfra == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipoInfra);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<TipoInfraestructura>> SaveTipoInfraestructura([FromBody] TipoInfraestructuraDto tipoinfradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoInfraestructuraDto, TipoInfraestructura>();
            });
            var _mapper = new Mapper(config);
            var _tipoinfra = _mapper.Map<TipoInfraestructura>(tipoinfradto);
            _itipoinfra.Add(_tipoinfra);
            await _itipoinfra.SaveAsync();
            if (tipoinfradto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipoinfradto.IdTipoInfraestructura = _tipoinfra.IdTipoInfraestructura;
            return CreatedAtAction(nameof(SaveTipoInfraestructura), new { IdTipoInfraestructura = tipoinfradto.IdTipoInfraestructura });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoInfraestructuraDto>> Put(int id, [FromBody] TipoInfraestructuraDto tipoinfradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoInfraestructuraDto, TipoInfraestructura>();
            });
            var _mapper = new Mapper(config);

            if (tipoinfradto == null)
                return NotFound(new ApiResponse(404, "El tipo de Ingraestructura solicitado no existe."));

            var _tipoinfra = await _itipoinfra.GetByIdAsync(id);
            if (_tipoinfra == null)
                return NotFound(new ApiResponse(404, "El tipo de Ingraestructura solicitado no existe."));

            var _tipoinfradto = _mapper.Map<TipoInfraestructura>(tipoinfradto);
            _itipoinfra.Update(_tipoinfradto);
            await _itipoinfra.SaveAsync();
            return tipoinfradto;
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _espaciofis = await _itipoinfra.GetByIdAsync(id);
            if (_espaciofis == null)
                return NotFound(new ApiResponse(404, "La Carrera que solicita no existe."));

            _itipoinfra.Remove(_espaciofis);
            await _itipoinfra.SaveAsync();

            return NoContent();
        }
    }
}
