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
    [Route("api/provincia")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ProvinciaController : ControllerBase
    {
        private readonly IProvinciaRepository _iprovincia;
        private readonly IMapper _mapper;

        public ProvinciaController(IProvinciaRepository provinciarepo, IMapper mapper)
        {
            _iprovincia = provinciarepo;
            _mapper = mapper;
        }

        //[Route("listarPage")]
        //[HttpGet]
        //public async Task<ActionResult<Pager<Provincium>>> GetAllProvincias([FromQuery] Params provinciaParams)
        //{
        //    var provincia = await _iprovincia.GetAllAsync(provinciaParams.PageIndex, provinciaParams.PageSize,
        //                            provinciaParams.Search);
        //    return new Pager<Provincium>(provincia.registros, provincia.totalRegistros,
        //    provinciaParams.PageIndex, provinciaParams.PageSize, provinciaParams.Search);
        //}

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincium>>> GetAllProvincia()
        {
            var provincia = await _iprovincia.GetAllAsync();
            if (provincia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(provincia);
        }

        [Route("GetAllProvincia")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provincium>>> GetAllByProvincia()
        {
            var provincia = await _iprovincia.GetAllByProvincia();
            if (provincia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(provincia);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<Provincium>> GetProvinciabyId(int id)
        {
            var provincia = await _iprovincia.GetByIdAsync(id);
            if (provincia == null)
                return NotFound(new ApiResponse(404));
            return Ok(provincia);
        }

        [Route("GetByIdPais/{id}")]
        [HttpGet]
        public async Task<ActionResult<Provincium>> GetByIdPais(int id)
        {
            var provincia = await _iprovincia.GetByIdPaisAsync(id);
            if (provincia == null)
                return NotFound(new ApiResponse(404));
            return Ok(provincia);
        }

        [Route("GetByCodProvincia/{cod}")]
        [HttpGet]
        public async Task<ActionResult<Provincium>> GetAllByCodProvincia(string cod)
        {
            var provincia = await _iprovincia.GetByCodProvincia(cod);
            if (provincia == null)
                return NotFound(new ApiResponse(404));
            return Ok(provincia);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<Provincium>> SaveProvincia([FromBody] ProvinciaDto provinciadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProvinciaDto, Provincium>();
            });
            var _mapper = new Mapper(config);
            var _provincia = _mapper.Map<Provincium>(provinciadto);
            _iprovincia.Add(_provincia);
            await _iprovincia.SaveAsync();
            if (provinciadto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            provinciadto.IdProvincia = _provincia.IdProvincia;
            return CreatedAtAction(nameof(SaveProvincia), new { IdProvincia = provinciadto.IdProvincia });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<ProvinciaDto>> Put(int id, [FromBody] ProvinciaDto provinciadto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProvinciaDto, Provincium>();
            });
            var _mapper = new Mapper(config);

            if (provinciadto == null)
                return NotFound(new ApiResponse(404, "La Povincia solicitado no existe."));

            var _provincia = await _iprovincia.GetByIdAsync(id);
            if (_provincia == null)
                return NotFound(new ApiResponse(404, "La Povincia solicitado no existe."));

            var _provinciadto = _mapper.Map<Provincium>(provinciadto);
            _iprovincia.Update(_provinciadto);
            await _iprovincia.SaveAsync();
            return provinciadto;
        }
    }
}
