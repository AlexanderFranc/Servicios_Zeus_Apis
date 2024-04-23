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
    [Route("api/infraestructura")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class InfraestructuraController : ControllerBase
    {
        private readonly IInfraestructuraRepository _iinfraestructura;
        private readonly IMapper _mapper;

        public InfraestructuraController(IInfraestructuraRepository infraestructurarepo, IMapper mapper)
        {
            _iinfraestructura = infraestructurarepo;
            _mapper = mapper;
        }
        [Route("GetByInfraestructura")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Infraestructura>>> GetByInfraestructura()
        {
            var infra = await _iinfraestructura.GetAllByInfraestructuraAsync();
            if (infra == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(infra);
        }
        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Infraestructura>>> GetAllInfraestructura()
        {
            var infra = await _iinfraestructura.GetAllAsync();
            if (infra == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(infra);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<Infraestructura>> GetInfraestructurabyId(int id)
        {
            var infa = await _iinfraestructura.GetByIdAsync(id);
            if (infa == null)
                return NotFound(new ApiResponse(404));
            return Ok(infa);
        }

        [Route("findByTipo/{id}")]
        [HttpGet]
        public async Task<ActionResult<Infraestructura>> GetfindByTipo(int id)
        {
            var infa = await _iinfraestructura.GetByTipoInfraAsync(id);
            if (infa == null)
                return NotFound(new ApiResponse(404));
            return Ok(infa);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<Infraestructura>> SaveInfraestructura([FromBody] InfraestructuraDto infradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InfraestructuraDto, Infraestructura>();
            });
            var _mapper = new Mapper(config);
            var _infra = _mapper.Map<Infraestructura>(infradto);
            _iinfraestructura.Add(_infra);
            await _iinfraestructura.SaveAsync();
            if (infradto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            infradto.IdInfraestructura = _infra.IdInfraestructura;
            return CreatedAtAction(nameof(SaveInfraestructura), new { IdInfraestructura = infradto.IdInfraestructura });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<InfraestructuraDto>> Put(int id, [FromBody] InfraestructuraDto infradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InfraestructuraDto, Infraestructura>();
            });
            var _mapper = new Mapper(config);

            if (infradto == null)
                return NotFound(new ApiResponse(404, "La Infraestructura solicitado no existe."));

            var _infra = await _iinfraestructura.GetByIdAsync(id);
            if (_infra == null)
                return NotFound(new ApiResponse(404, "La Infraestructura solicitado no existe."));

            var _infradto = _mapper.Map<Infraestructura>(infradto);
            _iinfraestructura.Update(_infradto);
            await _iinfraestructura.SaveAsync();
            return infradto;
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _infra = await _iinfraestructura.GetByIdAsync(id);
            if (_infra == null)
                return NotFound(new ApiResponse(404, "La Infraestructura que solicita no existe."));

            _iinfraestructura.Remove(_infra);
            await _iinfraestructura.SaveAsync();

            return NoContent();
        }
    }
}
