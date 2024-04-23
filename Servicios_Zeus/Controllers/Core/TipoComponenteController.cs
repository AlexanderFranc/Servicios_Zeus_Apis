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
    [Route("api/tipoComponente")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoComponenteController : ControllerBase
    {
        private readonly ITipoComponenteRepository _itipocomp;
        private readonly IMapper _mapper;

        public TipoComponenteController(ITipoComponenteRepository tipocomp, IMapper mapper)
        {
            _itipocomp = tipocomp;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoComponente>>> GetAllTipoComponente()
        {
            var tipoComp = await _itipocomp.GetAllAsync();
            if (tipoComp == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoComp);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoComponente>> GetTipoComponentebyId(int id)
        {
            var tipocomp = await _itipocomp.GetByIdAsync(id);
            if (tipocomp == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipocomp);
        }

        [Route("GetByCod/{cod}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoComponente>>> GetTipoComponentebyCod(string cod)
        {
            var tipocomp = await _itipocomp.GetByCodeTipoComponenteAsync(cod);
            if (tipocomp == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipocomp);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<TipoComponente>> SaveTipoComponente([FromBody] TipoComponenteDto tipocompdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoComponenteDto, TipoComponente>();
            });
            var _mapper = new Mapper(config);
            var _tipoComp = _mapper.Map<TipoComponente>(tipocompdto);
            _itipocomp.Add(_tipoComp);
            await _itipocomp.SaveAsync();
            if (tipocompdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipocompdto.IdTipoComponente = _tipoComp.IdTipoComponente;
            return CreatedAtAction(nameof(SaveTipoComponente), new { IdTipoComponente = tipocompdto.IdTipoComponente });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoComponenteDto>> Put(int id, [FromBody] TipoComponenteDto tipocompdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoComponenteDto, TipoComponente>();
            });
            var _mapper = new Mapper(config);

            if (tipocompdto == null)
                return NotFound(new ApiResponse(404, "El Tipo de Componente solicitado no existe."));

            var _tipocomp = await _itipocomp.GetByIdAsync(id);
            if (_tipocomp == null)
                return NotFound(new ApiResponse(404, "El Tipo de Componente solicitado no existe."));

            var _tipocompdto = _mapper.Map<TipoComponente>(tipocompdto);
            _itipocomp.Update(_tipocompdto);
            await _itipocomp.SaveAsync();
            return tipocompdto;
        }



        [Route("GetAllTipoSubtipo")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoComponenteDto>>> GetAllTipoSubtipo()
        {
            var tipoComp = await _itipocomp.TipoSubtipoCoponente();
            if (tipoComp == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoComp);
        }


    }
}
