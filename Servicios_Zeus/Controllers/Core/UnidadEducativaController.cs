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
    public class UnidadEducativaController : ControllerBase
    {
        private readonly IUnidadEducativaRepository _iunidadEdu;
        private readonly IMapper _mapper;
        public UnidadEducativaController(IUnidadEducativaRepository unidadEdurepo, IMapper mapper)
        {
            _iunidadEdu = unidadEdurepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadEducativa>>> GetAllnidadEducativa()
        {
            var unidadEdu = await _iunidadEdu.GetAllAsync();
            if (unidadEdu == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(unidadEdu);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<UnidadEducativa>> GetUnidadEducativabyId(int id)
        {
            var unidadEdu = await _iunidadEdu.GetByIdAsync(id);
            if (unidadEdu == null)
                return NotFound(new ApiResponse(404));
            return Ok(unidadEdu);
        }

        [Route("GetByTipoUnidad/{tipo}")]
        [HttpGet]
        public async Task<ActionResult<UnidadEducativa>> GetUnidadEducativabyTipo(int tipo)
        {
            var unidadEdu = await _iunidadEdu.GetByTipoUnidadEdu(tipo);
            if (unidadEdu == null)
                return NotFound(new ApiResponse(404));
            return Ok(unidadEdu);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<UnidadEducativa>> SaveUnidadEducativa([FromBody] UnidadEducativaDto unidadEdudto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnidadEducativaDto, UnidadEducativa>();
            });
            var _mapper = new Mapper(config);
            var _unidadEdu = _mapper.Map<UnidadEducativa>(unidadEdudto);
            _iunidadEdu.Add(_unidadEdu);
            await _iunidadEdu.SaveAsync();
            if (unidadEdudto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            unidadEdudto.IdUnidadEducativa = _unidadEdu.IdUnidadEducativa;
            return CreatedAtAction(nameof(SaveUnidadEducativa), new { IdUnidadEducativa = unidadEdudto.IdUnidadEducativa });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<UnidadEducativaDto>> Put(int id, [FromBody] UnidadEducativaDto unidadEdudto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UnidadEducativaDto, UnidadEducativa>();
            });
            var _mapper = new Mapper(config);

            if (unidadEdudto == null)
                return NotFound(new ApiResponse(404, "El Nivel Academico solicitado no existe."));

            var _unidadEdu = await _iunidadEdu.GetByIdAsync(id);
            if (_unidadEdu == null)
                return NotFound(new ApiResponse(404, "El Nivel Academico solicitado no existe."));

            var _unidadEdudto = _mapper.Map<UnidadEducativa>(unidadEdudto);
            _iunidadEdu.Update(_unidadEdudto);
            await _iunidadEdu.SaveAsync();
            return unidadEdudto;
        }
    }
}
