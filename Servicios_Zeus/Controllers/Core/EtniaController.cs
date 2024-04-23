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
    public class EtniaController : ControllerBase
    {
        private readonly IEtniaRepository _ietnia;
        private readonly IMapper _mapper;
        public EtniaController(IEtniaRepository etniarepo, IMapper mapper)
        {
            _ietnia = etniarepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Etnium>>> GetAllEtnia()
        {
            var etnia = await _ietnia.GetAllAsync();
            if (etnia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(etnia);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Etnium>> GetEtniabyId(int id)
        {
            var etnia = await _ietnia.GetByIdAsync(id);
            if (etnia == null)
                return NotFound(new ApiResponse(404));
            return Ok(etnia);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Etnium>> SaveEtnia([FromBody] EtniaDto etniadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EtniaDto, Etnium>();
            });
            var _mapper = new Mapper(config);
            var _etnia = _mapper.Map<Etnium>(etniadto);
            _ietnia.Add(_etnia);
            await _ietnia.SaveAsync();
            if (etniadto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            etniadto.IdEtnia = _etnia.IdEtnia;
            return CreatedAtAction(nameof(SaveEtnia), new { IdEtnia = etniadto.IdEtnia });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<EtniaDto>> Put(int id, [FromBody] EtniaDto etniadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EtniaDto, Etnium>();
            });
            var _mapper = new Mapper(config);

            if (etniadto == null)
                return NotFound(new ApiResponse(404, "La Etnia solicitado no existe."));

            var _etnia = await _ietnia.GetByIdAsync(id);
            if (_etnia == null)
                return NotFound(new ApiResponse(404, "La Etnia solicitado no existe."));

            var _etniadto = _mapper.Map<Etnium>(etniadto);
            _ietnia.Update(_etniadto);
            await _ietnia.SaveAsync();
            return etniadto;
        }
    }
}
