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
    [Route("api/estadoPe")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class EstadoPeController : ControllerBase
    {
        private readonly IEstadoPeRepository _iestadope;
        private readonly IMapper _mapper;
        public EstadoPeController(IEstadoPeRepository estadoperepo, IMapper mapper)
        {
            _iestadope = estadoperepo;
            _mapper = mapper;
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoPe>>> GetAll()
        {
            var estadope = await _iestadope.GetAllAsync();
            if (estadope == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(estadope);
        }
        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<EstadoPe>>> GetAll([FromQuery] Params estadopeParams)
        {
            var estadope = await _iestadope.GetAllAsync(estadopeParams.PageIndex, estadopeParams.PageSize,
                                    estadopeParams.Search);
            return new Pager<EstadoPe>(estadope.registros, estadope.totalRegistros,
            estadopeParams.PageIndex, estadopeParams.PageSize, estadopeParams.Search);
        }



        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<EstadoPe>> Save([FromBody] EstadoPEDto estadopedto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EstadoPEDto,EstadoPe>();
            });
            var _mapper = new Mapper(config);
            var _estadope = _mapper.Map<EstadoPe>(estadopedto);
            _iestadope.Add(_estadope);
            await _iestadope.SaveAsync();
            if (estadopedto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            estadopedto.IdEstadoPe = _estadope.IdEstadoPe;
            return CreatedAtAction(nameof(Save), new { IdEstadoPe = estadopedto.IdEstadoPe });

        }
        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<EstadoPEDto>> Put(int id, [FromBody] EstadoPEDto estadopeDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EstadoPe, EstadoPEDto>();
            });
            var _mapper = new Mapper(config);

            if (estadopeDto == null)
                return NotFound(new ApiResponse(404, "El estado solicitada no existe."));

            var _estadope = await _iestadope.GetByIdAsync(id);
            if (_estadope == null)
                return NotFound(new ApiResponse(404, "El estado solicitada no existe."));

            var _estadopedto = _mapper.Map<EstadoPe>(estadopeDto);
            _iestadope.Update(_estadopedto);
            await _iestadope.SaveAsync();
            return estadopeDto;
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _materia = await _iestadope.GetByIdAsync(id);
            if (_materia == null)
                return NotFound(new ApiResponse(404, "El estado que solicita no existe."));

            _iestadope.Remove(_materia);
            await _iestadope.SaveAsync();

            return NoContent();
        }
    }
}
