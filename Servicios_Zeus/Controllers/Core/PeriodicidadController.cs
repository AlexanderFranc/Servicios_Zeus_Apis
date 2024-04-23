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
    [Route("api/Periodicidad")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PeriodicidadController : ControllerBase
    {
        private readonly IPeriodicidadRepository _iperiodicidad;
        private readonly IMapper _mapper;
        public PeriodicidadController(IPeriodicidadRepository periodicidadrepo, IMapper mapper)
        {
            _iperiodicidad = periodicidadrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]

        public async Task<ActionResult<Pager<Periodicidad>>> GetAll([FromQuery] Params periodicidadParams)
        {
            var periodicidad = await _iperiodicidad.GetAllAsync(periodicidadParams.PageIndex, periodicidadParams.PageSize,
                                    periodicidadParams.Search);
            return new Pager<Periodicidad>(periodicidad.registros, periodicidad.totalRegistros,
            periodicidadParams.PageIndex, periodicidadParams.PageSize, periodicidadParams.Search);
        }
        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Periodicidad>>> GetAll()
        {
            var periodicidad = await _iperiodicidad.GetAllAsync();
            if (periodicidad == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(periodicidad);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Periodicidad>> GetPeriodicidadbyId(int id)
        {
            var periodicidad = await _iperiodicidad.GetByIdAsync(id);
            if (periodicidad == null)
                return NotFound(new ApiResponse(404));
            return Ok(periodicidad);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Periodicidad>> SavePeriodicidad([FromBody] PeriodicidadDto periodicidadto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PeriodicidadDto, Periodicidad>();
            });
            var _mapper = new Mapper(config);
            var _periodicidad = _mapper.Map<Periodicidad>(periodicidadto);
            _iperiodicidad.Add(_periodicidad);
            await _iperiodicidad.SaveAsync();
            if (periodicidadto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            periodicidadto.IdPeriodicidad = _periodicidad.IdPeriodicidad;
            return CreatedAtAction(nameof(SavePeriodicidad), new { IdPeriodicidad = periodicidadto.IdPeriodicidad });

        }
        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<PeriodicidadDto>> Put(int id, [FromBody] PeriodicidadDto periodicidadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PeriodicidadDto, Periodicidad>();
            });
            var _mapper = new Mapper(config);

            if (periodicidadto == null)
                return NotFound(new ApiResponse(404, "El Periodicidad solicitado no existe."));

            var _periodicidad = await _iperiodicidad.GetByIdAsync(id);
            if (_periodicidad == null)
                return NotFound(new ApiResponse(404, "El Periodicidad solicitado no existe."));

            var _periodicidaddto = _mapper.Map<Periodicidad>(periodicidadto);
            _iperiodicidad.Update(_periodicidad);
            await _iperiodicidad.SaveAsync();
            return periodicidadto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _iperiodicidad.GetByIdAsync(id);
            if (producto == null)
                return NotFound(new ApiResponse(404, "La Periodicidad que solicita no existe."));

            _iperiodicidad.Remove(producto);
            await _iperiodicidad.SaveAsync();

            return NoContent();
        }

    }
}
