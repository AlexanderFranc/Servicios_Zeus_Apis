using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/uoc")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class UnidadOrganizacionalCurricularController : ControllerBase
    {
        private readonly IUnidadOrganizacionalCurricularRepository _iUOC;
        private readonly IMapper _mapper;
        public UnidadOrganizacionalCurricularController(IUnidadOrganizacionalCurricularRepository UOCrepo, IMapper mapper)
        {
            _iUOC = UOCrepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<Pager<UnidadOrganizacionCurricular>>> GetAllUOC()//[FromQuery] Params uocParams
        {
            var uoc = await _iUOC.GetAllAsync();
            if (uoc == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(uoc);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Pai>> GetUOCbyId(int id)
        {
            var uoc = await _iUOC.GetByIdAsync(id);
            if (uoc == null)
                return NotFound(new ApiResponse(404));
            return Ok(uoc);
        }

        [Route("GetByActivas")]
        [HttpGet]
        public async Task<ActionResult<Pai>> GetAllUOCActivasAsync()
        {
            var uoc = await _iUOC.GetAllUOCActivasAsync();
            if (uoc == null)
                return NotFound(new ApiResponse(404));
            return Ok(uoc);
        }

        [Route("GetByCod/{cod}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadOrganizacionCurricular>>> GetUOCbyCod(string cod)
        {
            var uoc = await _iUOC.GetByCoduocAsync(cod);
            if (uoc == null)
                return NotFound(new ApiResponse(404));
            return Ok(uoc);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<UnidadOrganizacionCurricular>> SaveUOC([FromBody] UnidadOrganizacionCurricularDto uocdto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnidadOrganizacionCurricularDto, UnidadOrganizacionCurricular>();
            });
            var _mapper = new Mapper(config);
            var _uoc = _mapper.Map<UnidadOrganizacionCurricular>(uocdto);
            _iUOC.Add(_uoc);
            await _iUOC.SaveAsync();
            if (uocdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            uocdto.IdUOC = _uoc.IdUoc;
            return CreatedAtAction(nameof(SaveUOC), new { IdUOC = uocdto.IdUOC });

        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<UnidadOrganizacionCurricularDto>> Put(int id, [FromBody] UnidadOrganizacionCurricularDto uocdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnidadOrganizacionCurricularDto, UnidadOrganizacionCurricular>();
            });
            var _mapper = new Mapper(config);



            if (uocdto == null)
                return NotFound(new ApiResponse(404, "La UOC solicitada no existe."));

            var _uoc = await _iUOC.GetByIdAsync(id);
            if (_uoc == null)
                return NotFound(new ApiResponse(404, "La UOC solicitada no existe."));

            var _paisdto = _mapper.Map<UnidadOrganizacionCurricular>(uocdto);
            _iUOC.Update(_paisdto);
            await _iUOC.SaveAsync();
            return uocdto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _iUOC.GetByIdAsync(id);
            if (producto == null)
                return NotFound(new ApiResponse(404, "La UOC que solicita no existe."));

            _iUOC.Remove(producto);
            await _iUOC.SaveAsync();

            return NoContent();
        }
    }
}
