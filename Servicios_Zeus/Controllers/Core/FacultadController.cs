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
    [Route("api/facultad")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class FacultadController : ControllerBase
    {
        private readonly IFacultadRepository _ifaultad;
        private readonly IMapper _mapper;
        public FacultadController(IFacultadRepository facultadrepo, IMapper mapper)
        {
            _ifaultad = facultadrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<Facultad>>> GetAllFacultad([FromQuery] Params facultadParams)
        {
            var facultad = await _ifaultad.GetAllAsync(facultadParams.PageIndex, facultadParams.PageSize,
                                    facultadParams.Search);
            return new Pager<Facultad>(facultad.registros, facultad.totalRegistros,
            facultadParams.PageIndex, facultadParams.PageSize, facultadParams.Search);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facultad>>> GetAllFacultad()
        {
            var facultad = await _ifaultad.GetAllAsync();
            if (facultad == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(facultad);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Facultad>> GetFacultadbyId(int id)
        {
            var facultad = await _ifaultad.GetByIdAsync(id);
            if (facultad == null)
                return NotFound(new ApiResponse(404));
            return Ok(facultad);
        }

        //[Route("GetFacultadbyCod/{codfacultad}")]
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Facultad>>> GetFacultadbyCod(string codfacultad)
        //{
        //    var facultad = await _ifaultad.GetByCodeFacultadAsync(codfacultad);
        //    if (facultad == null)
        //        return NotFound(new ApiResponse(404));
        //    return Ok(facultad);
        //}

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Facultad>> SaveFacultad([FromBody] FacultadDto facultaddto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FacultadDto, Facultad>();
            });
            var _mapper = new Mapper(config);
            var _facultad = _mapper.Map<Facultad>(facultaddto);
            _ifaultad.Add(_facultad);
            await _ifaultad.SaveAsync();
            if (facultaddto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            facultaddto.IdFacultad = _facultad.IdFacultad;
            return CreatedAtAction(nameof(SaveFacultad), new { IdFacultad = facultaddto.IdFacultad });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<FacultadDto>> Put(int id, [FromBody] FacultadDto facultaddto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FacultadDto, Facultad>();
            });
            var _mapper = new Mapper(config);

            if (facultaddto == null)
                return NotFound(new ApiResponse(404, "La Facultad solicitado no existe."));

            var _facultad = await _ifaultad.GetByIdAsync(id);
            if (_facultad == null)
                return NotFound(new ApiResponse(404, "La Facultad solicitado no existe."));

            var _facultaddto = _mapper.Map<Facultad>(facultaddto);
            _ifaultad.Update(_facultaddto);
            await _ifaultad.SaveAsync();
            return facultaddto;
        }

    }
}
