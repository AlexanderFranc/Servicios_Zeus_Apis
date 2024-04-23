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
    [ApiVersion("1.0")]
    [Route("api/tipoActividad")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoActividadController : ControllerBase
    {
        private readonly ITipoActividadRepository _itipoactividad;
        private readonly IMapper _mapper;
        public TipoActividadController(ITipoActividadRepository tipoactividadrepo, IMapper mapper)
        {
            _itipoactividad = tipoactividadrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]

        public async Task<ActionResult<Pager<TipoActividad>>> GetAllTipoActividad([FromQuery] Params tipoactividadParams)
        {
            var tipoactividad = await _itipoactividad.GetAllAsync(tipoactividadParams.PageIndex, tipoactividadParams.PageSize,
                                    tipoactividadParams.Search);
            return new Pager<TipoActividad>(tipoactividad.registros, tipoactividad.totalRegistros,
            tipoactividadParams.PageIndex, tipoactividadParams.PageSize, tipoactividadParams.Search);
        }



        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<TipoActividad>>> GetAllTipoActividad()
        {
            var tipoactividad = await _itipoactividad.GetAllAsync();
            if (tipoactividad == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoactividad);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoActividad>> GetTipoActividadbyId(int id)
        {
            var tipoactividad = await _itipoactividad.GetByIdAsync(id);
            if (tipoactividad == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipoactividad);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<TipoActividad>> SaveTipoActividad([FromBody] TipoActividadDto tipoactividaddto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoActividadDto, TipoActividad>();
            });
            var _mapper = new Mapper(config);
            var _tipoactividad = _mapper.Map<TipoActividad>(tipoactividaddto);
            _itipoactividad.Add(_tipoactividad);
            await _itipoactividad.SaveAsync();
            if (tipoactividaddto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipoactividaddto.IdTipoActividad = _tipoactividad.IdTipoActividad;
            return CreatedAtAction(nameof(SaveTipoActividad), new { IdTipoActividad = tipoactividaddto.IdTipoActividad });

        }
        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoActividadDto>> Put(int id, [FromBody] TipoActividadDto tipoactividaddto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoActividadDto, TipoActividad>();
            });
            var _mapper = new Mapper(config);

            if (tipoactividaddto == null)
                return NotFound(new ApiResponse(404, "El tipo de actividad solicitado no existe."));

            var _tipoactividad = await _itipoactividad.GetByIdAsync(id);
            if (_tipoactividad == null)
                return NotFound(new ApiResponse(404, "El tipo de actividad solicitado no existe."));

            var _tipoactividaddto = _mapper.Map<TipoActividad>(tipoactividaddto);
            _itipoactividad.Update(_tipoactividaddto);
            await _itipoactividad.SaveAsync();
            return tipoactividaddto;
        }
    }
}
