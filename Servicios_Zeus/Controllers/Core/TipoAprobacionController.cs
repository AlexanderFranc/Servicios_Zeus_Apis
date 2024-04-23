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
    [Route("api/tipoAprobacion")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoAprobacionController : ControllerBase
    {
        private readonly ITipoAprobacionRepository _itipoaprobacion;
        private readonly IMapper _mapper;
        public TipoAprobacionController(ITipoAprobacionRepository tipoaprobacionrepo, IMapper mapper)
        {
            _itipoaprobacion = tipoaprobacionrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]

        public async Task<ActionResult<Pager<TipoAprobacion>>> GetAllTipoAprobacion([FromQuery] Params tipoaprobacionParams)
        {
            var tipoaprobacion = await _itipoaprobacion.GetAllAsync(tipoaprobacionParams.PageIndex, tipoaprobacionParams.PageSize,
                                    tipoaprobacionParams.Search);
            return new Pager<TipoAprobacion>(tipoaprobacion.registros, tipoaprobacion.totalRegistros,
            tipoaprobacionParams.PageIndex, tipoaprobacionParams.PageSize, tipoaprobacionParams.Search);
        }



        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<TipoAprobacion>>> GetAllTipoAprobacion()
        {
            var tipoaprobacion = await _itipoaprobacion.GetAllAsync();
            if (tipoaprobacion == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoaprobacion);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoAprobacion>> GetTipoAprobacionbyId(int id)
        {
            var tipoaprobacion = await _itipoaprobacion.GetByIdAsync(id);
            if (tipoaprobacion == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipoaprobacion);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<TipoAprobacion>> SaveTipoAprobacion([FromBody] TipoAprobacionDto tipoaprobaciondto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoAprobacionDto, TipoAprobacion>();
            });
            var _mapper = new Mapper(config);
            var _tipoaprobacion = _mapper.Map<TipoAprobacion>(tipoaprobaciondto);
            _itipoaprobacion.Add(_tipoaprobacion);
            await _itipoaprobacion.SaveAsync();
            if (tipoaprobaciondto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipoaprobaciondto.IdTipoAprobacion = _tipoaprobacion.IdTipoAprobacion;
            return CreatedAtAction(nameof(SaveTipoAprobacion), new { IdTipoAprobacion = tipoaprobaciondto.IdTipoAprobacion });

        }
        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoAprobacionDto>> Put(int id, [FromBody] TipoAprobacionDto tipoaprobaciondto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoAprobacionDto, TipoAprobacion>();
            });
            var _mapper = new Mapper(config);

            if (tipoaprobaciondto == null)
                return NotFound(new ApiResponse(404, "El tipo de aprobacion solicitado no existe."));

            var _tipoaprobacion = await _itipoaprobacion.GetByIdAsync(id);
            if (_tipoaprobacion == null)
                return NotFound(new ApiResponse(404, "El tipo de aprobacion solicitado no existe."));

            var _tipoaprobaciondto = _mapper.Map<TipoAprobacion>(tipoaprobaciondto);
            _itipoaprobacion.Update(_tipoaprobaciondto);
            await _itipoaprobacion.SaveAsync();
            return tipoaprobaciondto;
        }
    }
}
