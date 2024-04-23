using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [Authorize]
    [Route("api/tipoMateriaCatalogo")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoMateriaCatalogoController : ControllerBase
    {
        private readonly ITipoMateriaCatalogoRepository _itipomatc;
        private readonly IMapper _mapper;
        public TipoMateriaCatalogoController(ITipoMateriaCatalogoRepository tipoMatPrepo, IMapper mapper)
        {
            _itipomatc = tipoMatPrepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<IEnumerable<TipoMateriaCatalogo>>> GetAllTipoMateria()
        {
            var tipoMatP = await _itipomatc.GetAllAsync();
            if (tipoMatP == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoMatP);
        }


        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoMateriaCatalogo>> GetTipoMatPbyId(int id)
        {
            var tipoMP = await _itipomatc.GetByIdAsync(id);
            if (tipoMP == null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(tipoMP);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<TipoMateriaCatalogo>> SaveTipoMateriaPrincipal([FromBody] TipoMateriaCatalogoDto TipoMatPdto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoMateriaCatalogoDto, TipoMateriaCatalogo>();
            });
            var _mapper = new Mapper(config);
            var _tipomatp = _mapper.Map<TipoMateriaCatalogo>(TipoMatPdto);
            _itipomatc.Add(_tipomatp);
            await _itipomatc.SaveAsync();
            if (TipoMatPdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            TipoMatPdto.IdTipoMateriaCatalogo = _tipomatp.IdTipoMateriaCatalogo;
            return CreatedAtAction(nameof(SaveTipoMateriaPrincipal), new { IdTipoMateriaCatalogo = TipoMatPdto.IdTipoMateriaCatalogo });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoMateriaCatalogoDto>> Put(int id, [FromBody] TipoMateriaCatalogoDto tipomatcatdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoMateriaCatalogoDto, TipoMateriaCatalogo>();
            });
            var _mapper = new Mapper(config);

            if (tipomatcatdto == null)
                return NotFound(new ApiResponse(404, "El Tipo de Materia Principal solicitado no existe."));

            var _tipomp = await _itipomatc.GetByIdAsync(id);
            if (_tipomp == null)
                return NotFound(new ApiResponse(404, "El Tipo de Materia Principal solicitado no existe."));

            var _tipomatpsdto = _mapper.Map<TipoMateriaCatalogo>(tipomatcatdto);
            _itipomatc.Update(_tipomatpsdto);
            await _itipomatc.SaveAsync();
            return tipomatcatdto;
        }


    }
}
