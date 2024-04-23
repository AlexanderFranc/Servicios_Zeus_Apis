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
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoDiscapacidadController : ControllerBase
    {
        private readonly ITipoDiscapacidadRepository _itipoDisc;
        private readonly IMapper _mapper;
        public TipoDiscapacidadController(ITipoDiscapacidadRepository tipoDiscrepo, IMapper mapper)
        {
            _itipoDisc = tipoDiscrepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDiscapacidad>>> GetAllTipoDiscapacidad()
        {
            var tipoDisc = await _itipoDisc.GetAllAsync();
            if (tipoDisc == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoDisc);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoDiscapacidad>> GetTipoDiscapacidadbyId(int id)
        {
            var tipoDisc = await _itipoDisc.GetByIdAsync(id);
            if (tipoDisc == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipoDisc);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<TipoDiscapacidad>> SaveTipoDiscapacidad([FromBody] TipoDiscapacidadDto tipoDiscdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoDiscapacidadDto, TipoDiscapacidad>();
            });
            var _mapper = new Mapper(config);
            var _tipoDisc = _mapper.Map<TipoDiscapacidad>(tipoDiscdto);
            _itipoDisc.Add(_tipoDisc);
            await _itipoDisc.SaveAsync();
            if (tipoDiscdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipoDiscdto.IdTipoDiscapacidad = _tipoDisc.IdTipoDiscapacidad;
            return CreatedAtAction(nameof(SaveTipoDiscapacidad), new { IdTipoDiscapacidad = tipoDiscdto.IdTipoDiscapacidad });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoDiscapacidadDto>> Put(int id, [FromBody] TipoDiscapacidadDto tipoDiscdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoDiscapacidadDto, TipoDiscapacidad>();
            });
            var _mapper = new Mapper(config);

            if (tipoDiscdto == null)
                return NotFound(new ApiResponse(404, "La Plublicacion solicitado no existe."));

            var _tipoDisc = await _itipoDisc.GetByIdAsync(id);
            if (_tipoDisc == null)
                return NotFound(new ApiResponse(404, "La Plublicacion solicitado no existe."));

            var _tipoDiscdto = _mapper.Map<TipoDiscapacidad>(tipoDiscdto);
            _itipoDisc.Update(_tipoDiscdto);
            await _itipoDisc.SaveAsync();
            return tipoDiscdto;
        }
    }
}
