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
    [Route("api/pais")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PaisController : ControllerBase
    {
        private readonly IPaisRepository _ipais;
        private readonly IMapper _mapper;
        public PaisController(IPaisRepository paisrepo, IMapper mapper)
        {
            _ipais = paisrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]

        public async Task<ActionResult<Pager<Pai>>> GetAllPais([FromQuery] Params paisParams)
        {
            var pais = await _ipais.GetAllAsync(paisParams.PageIndex, paisParams.PageSize,
                                    paisParams.Search);
            return new Pager<Pai>(pais.registros, pais.totalRegistros,
            paisParams.PageIndex, paisParams.PageSize, paisParams.Search);
        }


        
        [Route("GetAll")]
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Pai>>> GetAllPais()
        {
            var pais = await _ipais.GetAllAsync();
            if (pais == null)
                return NotFound(new ApiResponse(404,"La lista no contiene ningún elemento."));
            return Ok(pais);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Pai>> GetPaisbyId(int id)
        {
            var pais = await _ipais.GetByIdAsync(id);
            if(pais == null)
                return NotFound(new ApiResponse(404));
            return Ok(pais);
        }


        [Route("GetByCod/{cod}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pai>>> GetPaisbyCod(string cod)
        {
            var pais = await _ipais.GetByCodPaisAsync(cod);
            if (pais == null) 
                return NotFound(new ApiResponse(404));
            return Ok(pais);
        }
        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Pai>> SavePais([FromBody] PaisDto paisdto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PaisDto, Pai>();
            });
            var _mapper = new Mapper(config);
            var _pais = _mapper.Map<Pai>(paisdto);
            _ipais.Add(_pais);
            await  _ipais.SaveAsync(); 
            if (paisdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            paisdto.IdPais = _pais.IdPais;
            return CreatedAtAction(nameof(SavePais), new { IdPais = paisdto.IdPais });
            
        }
        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<PaisDto>> Put(int id, [FromBody] PaisDto paisdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PaisDto, Pai>();
            });
            var _mapper = new Mapper(config);

            if (paisdto == null)
                return NotFound(new ApiResponse(404, "El país solicitado no existe."));

            var _pais = await _ipais.GetByIdAsync(id);
            if (_pais == null)
                return NotFound(new ApiResponse(404, "El país solicitado no existe."));

            var _paisdto = _mapper.Map<Pai>(paisdto);
            _ipais.Update(_paisdto);
            await _ipais.SaveAsync();
            return paisdto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _ipais.GetByIdAsync(id);
            if (producto == null)
                return NotFound(new ApiResponse(404, "El Pais que solicita no existe."));

            _ipais.Remove(producto);
            await _ipais.SaveAsync();

            return NoContent();
        }
    }
}
