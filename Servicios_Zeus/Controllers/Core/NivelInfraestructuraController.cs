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
    [Route("api/nivel-infraestructura")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class NivelInfraestructuraController : ControllerBase
    {
        private readonly INivelInfraestructuraRepository _inivelinfra;
        private readonly IMapper _mapper;

        public NivelInfraestructuraController(INivelInfraestructuraRepository nivelinfrarepo, IMapper mapper)
        {
            _inivelinfra = nivelinfrarepo;
            _mapper = mapper;
        }

        [Route("listarPage")]
        [HttpGet]
        public async Task<ActionResult<Pager<NivelInfraestructura>>> GetAllNivelInfraestructuras([FromQuery] Params nivelinfraParams)
        {
            var nivelinfra = await _inivelinfra.GetAllAsync(nivelinfraParams.PageIndex, nivelinfraParams.PageSize,
                                    nivelinfraParams.Search);
            return new Pager<NivelInfraestructura>(nivelinfra.registros, nivelinfra.totalRegistros,
            nivelinfraParams.PageIndex, nivelinfraParams.PageSize, nivelinfraParams.Search);
        }

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelInfraestructura>>> GetAllNivelInfra()
        {
            var nivelinfra = await _inivelinfra.GetAllAsync();
            if (nivelinfra == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(nivelinfra);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<NivelInfraestructura>> GetNiveInfrabyId(int id)
        {
            var nivelinfra = await _inivelinfra.GetByIdAsync(id);
            if (nivelinfra == null)
                return NotFound(new ApiResponse(404));
            return Ok(nivelinfra);
        }

        //findByIdInfraestructura
        [Route("findByIdInfraestructura/{id}")]
        [HttpGet]
        public async Task<ActionResult<NivelInfraestructura>> GetfindByIdInfraestructura(int id)
        {
            var nivelinfra = await _inivelinfra.GetByIdInfraestructura(id);
            if (nivelinfra == null)
                return NotFound(new ApiResponse(404));
            return Ok(nivelinfra);
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<NivelInfraestructura>> GetAll()
        {
            var nivelinfra = await _inivelinfra.GetAllAsync();
            if (nivelinfra == null)
                return NotFound(new ApiResponse(404));
            return Ok(nivelinfra);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<NivelInfraestructura>> SaveNivelInfra([FromBody] NivelInfraestructuraDto nivelinfradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NivelInfraestructuraDto, NivelInfraestructura>();
            });
            var _mapper = new Mapper(config);
            var _nivelinfra = _mapper.Map<NivelInfraestructura>(nivelinfradto);
            _inivelinfra.Add(_nivelinfra);
            await _inivelinfra.SaveAsync();
            if (nivelinfradto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            nivelinfradto.IdNivelInfraestructura = _nivelinfra.IdNivelInfraestructura;
            return CreatedAtAction(nameof(SaveNivelInfra), new { IdNivelInfraestructura = nivelinfradto.IdNivelInfraestructura });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<NivelInfraestructuraDto>> Put(int id, [FromBody] NivelInfraestructuraDto nivelinfradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NivelInfraestructuraDto, NivelInfraestructura>();
            });
            var _mapper = new Mapper(config);

            if (nivelinfradto == null)
                return NotFound(new ApiResponse(404, "El Nivel de Infraestructura solicitado no existe."));

            var _nivelinfra = await _inivelinfra.GetByIdAsync(id);
            if (_nivelinfra == null)
                return NotFound(new ApiResponse(404, "El Nivel de Infraestructura solicitado no existe."));

            var _nivelinfradto = _mapper.Map<NivelInfraestructura>(nivelinfradto);
            _inivelinfra.Update(_nivelinfradto);
            await _inivelinfra.SaveAsync();
            return nivelinfradto;
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _espaciofis = await _inivelinfra.GetByIdAsync(id);
            if (_espaciofis == null)
                return NotFound(new ApiResponse(404, "La Carrera que solicita no existe."));

            _inivelinfra.Remove(_espaciofis);
            await _inivelinfra.SaveAsync();

            return NoContent();
        }
    }
}
