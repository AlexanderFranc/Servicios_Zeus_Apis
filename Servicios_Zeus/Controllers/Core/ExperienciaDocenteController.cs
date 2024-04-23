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
    [Route("api/ExperienciaDocente")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ExperienciaDocenteController : ControllerBase
    {
        private readonly IExperienciaDocenteRepository _iexperienciaDocente;
        private readonly IMapper _mapper;

        public ExperienciaDocenteController(IExperienciaDocenteRepository experienciaDocenterepo, IMapper mapper)
        {
            _iexperienciaDocente = experienciaDocenterepo;
            _mapper = mapper;

        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<ExperienciaDocente>>> GetAllExperienciaDocente([FromQuery] Params experienciaDocenteParams)
        {
            var experienciaDocente = await _iexperienciaDocente.GetAllAsync(experienciaDocenteParams.PageIndex, experienciaDocenteParams.PageSize,
                                    experienciaDocenteParams.Search);
            return new Pager<ExperienciaDocente>(experienciaDocente.registros, experienciaDocente.totalRegistros,
            experienciaDocenteParams.PageIndex, experienciaDocenteParams.PageSize, experienciaDocenteParams.Search);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<ExperienciaDocente>> GetEXperienciaDocentebyId(int id)
        {
            var experienciaDocente = await _iexperienciaDocente.GetByIdAsync(id);
            //PRUEBA
            if (experienciaDocente == null)
                return NotFound(new ApiResponse(404));
            return Ok(experienciaDocente);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<ExperienciaLaboral>> GetfindByDni(int id)
        {
            var experienciaDocente = await _iexperienciaDocente.GetByIdEmpleado(id);
            if (experienciaDocente == null)
                return NotFound(new ApiResponse(404));
            return Ok(experienciaDocente);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExperienciaDocente>>> GetAllExperienciaDocente()
        {
            var experienciaDocente = await _iexperienciaDocente.GetAllAsync();
            if (experienciaDocente == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(experienciaDocente);
        }

        //[Route("listar")]
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ExperienciaDocente>>> GetAllExperienciaDocente()
        //{
        //    var experienciaDocente = await _iexperienciaDocente.GetAllAsync();
        //    if (experienciaDocente == null)
        //        return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
        //    return Ok(experienciaDocente);
        //}





        //[Route("save")]
        //[HttpPost]
        //public async Task<ActionResult<ExperienciaDocente>> SaveEXperienciaDocente([FromBody] ExperienciaDocenteDto experienciaDocentedto)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<ExperienciaDocenteDto, ExperienciaDocente>();
        //    });
        //    var _mapper = new Mapper(config);
        //    var _experienciaDocente = _mapper.Map<ExperienciaDocente>(experienciaDocentedto);
        //    _iexperienciaDocente.Add(_experienciaDocente);
        //    await _iexperienciaDocente.SaveAsync();
        //    if (experienciaDocentedto == null)
        //    {
        //        return BadRequest(new ApiResponse(400));
        //    }
        //    experienciaDocentedto.IdExperienciaDocente = _experienciaDocente.IdExperienciaDocente;
        //    return CreatedAtAction(nameof(SaveEXperienciaDocente), new { IdExperienciaDocente = experienciaDocentedto.IdExperienciaDocente });
        //}

        //[Route("Save")]
        //[HttpPost]
        //public async Task<ActionResult<List<ExperienciaDocenteDto>>> SaveEXperienciaDocente([FromBody] List<ExperienciaDocente> docentes)
        //{

        //    List<ExperienciaDocente> ID_EXPERIENCIADOCENTE = new List<ExperienciaDocente>();

        //    foreach (var docente in docentes)
        //    {
        //        _iexperienciaDocente.Add(docente);
        //        await _iexperienciaDocente.SaveAsync();
        //        if (docente == null)
        //        {
        //            return BadRequest(new ApiResponse(400));
        //        }
        //        docente.IdExperienciaDocente = docente.IdExperienciaDocente;
        //        ID_EXPERIENCIADOCENTE.Add(new ExperienciaDocente { IdExperienciaDocente = docente.IdExperienciaDocente });
        //    }

        //    return CreatedAtAction(nameof(SaveEXperienciaDocente), ID_EXPERIENCIADOCENTE);
        //}

        [Route("Save")]
        [HttpPost]
        public bool SaveInfoExperienciaDocente([FromBody] ExperienciaDocenteDto experienciaDocentedto)
        {
            return _iexperienciaDocente.SaveInfoExperienciaDocente(experienciaDocentedto);
        }

        //[Route("save")]
        //[HttpPost]
        //public async Task<ActionResult<ExperienciaDocente>> SaveInfoExperienciaDocente([FromBody] ExperienciaDocenteDto experienciaDocentedto)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<ExperienciaDocenteDto, ExperienciaDocente>();
        //    });
        //    var _mapper = new Mapper(config);
        //    var _experienciaDocente = _mapper.Map<ExperienciaDocente>(experienciaDocentedto);
        //    _iexperienciaDocente.Add(_experienciaDocente);
        //    await _iexperienciaDocente.SaveAsync();
        //    if (experienciaDocentedto == null)
        //    {
        //        return BadRequest(new ApiResponse(400));
        //    }
        //    experienciaDocentedto.IdExperienciaDocente = _experienciaDocente.IdExperienciaDocente;
        //    return CreatedAtAction(nameof(SaveInfoExperienciaDocente), new { IdExperienciaDocente = experienciaDocentedto.IdExperienciaDocente });
        //}

        [Route("Update/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] List<ExperienciaDocenteDto> experienciaDocentedto)
        {
            return _iexperienciaDocente.EditInfoExperienciaDocente(experienciaDocentedto, id);
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _experienciaDocente = await _iexperienciaDocente.GetByIdAsync(id);
            if (_experienciaDocente == null)
                return NotFound(new ApiResponse(404, "El Empleado que solicita no existe."));

            _iexperienciaDocente.Remove(_experienciaDocente);
            await _iexperienciaDocente.SaveAsync();

            return NoContent();
        }

    }
}