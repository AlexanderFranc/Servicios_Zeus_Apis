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
    [Route("api/nivel-academico")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class NivelAcademicoController : ControllerBase
    {
        private readonly INivelAcademicoRepository _inivelAcad;
        private readonly IMapper _mapper;
        public NivelAcademicoController(INivelAcademicoRepository niverAcadrepo, IMapper mapper)
        {
            _inivelAcad = niverAcadrepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NivelAcademico>>> GetAllNiverAcademico()
        {
            var nivelAcad = await _inivelAcad.GetAllAsync();
            if (nivelAcad == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(nivelAcad);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<NivelAcademico>> GetNiverAcademicobyId(int id)
        {
            var nivelAcad = await _inivelAcad.GetByIdAsync(id);
            if (nivelAcad == null)
                return NotFound(new ApiResponse(404));
            return Ok(nivelAcad);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<NivelAcademico>> SaveNivelAcademico([FromBody] NivelAcademicoDto nivelAcaddto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NivelAcademicoDto, NivelAcademico>();
            });
            var _mapper = new Mapper(config);
            var _nivelAcad = _mapper.Map<NivelAcademico>(nivelAcaddto);
            _inivelAcad.Add(_nivelAcad);
            await _inivelAcad.SaveAsync();
            if (nivelAcaddto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            nivelAcaddto.IdNivelAcademico = _nivelAcad.IdNivelAcademico;
            return CreatedAtAction(nameof(SaveNivelAcademico), new { IdNivelAcademico = nivelAcaddto.IdNivelAcademico });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<NivelAcademicoDto>> Put(int id, [FromBody] NivelAcademicoDto nivelAcaddto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NivelAcademicoDto, NivelAcademico>();
            });
            var _mapper = new Mapper(config);

            if (nivelAcaddto == null)
                return NotFound(new ApiResponse(404, "El Nivel Academico solicitado no existe."));

            var _nivelAcad = await _inivelAcad.GetByIdAsync(id);
            if (_nivelAcad == null)
                return NotFound(new ApiResponse(404, "El Nivel Academico solicitado no existe."));

            var _nivelAcaddto = _mapper.Map<NivelAcademico>(nivelAcaddto);
            _inivelAcad.Update(_nivelAcaddto);
            await _inivelAcad.SaveAsync();
            return nivelAcaddto;
        }
    }

}
