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
    [Route("api/ExperienciaLaboral")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ExperienciaLaboralController : ControllerBase
    {
        private readonly IExperienciaLaboralRepository _iexperienciaLaboral;
        private readonly IMapper _mapper;

        public ExperienciaLaboralController(IExperienciaLaboralRepository experienciaLaboralrepo, IMapper mapper)
        {
            _iexperienciaLaboral = experienciaLaboralrepo;
            _mapper = mapper;

        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<ExperienciaLaboral>>> GetAllExperienciaLaboral([FromQuery] Params experienciaLaboralParams)
        {
            var experienciaLaboral = await _iexperienciaLaboral.GetAllAsync(experienciaLaboralParams.PageIndex, experienciaLaboralParams.PageSize,
                                    experienciaLaboralParams.Search);
            return new Pager<ExperienciaLaboral>(experienciaLaboral.registros, experienciaLaboral.totalRegistros,
            experienciaLaboralParams.PageIndex, experienciaLaboralParams.PageSize, experienciaLaboralParams.Search);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<ExperienciaLaboral>> GetfindByDni(int id)
        {
            var experienciaLaboral = await _iexperienciaLaboral.GetByIdEmpleado(id);
            if (experienciaLaboral == null)
                return NotFound(new ApiResponse(404));
            return Ok(experienciaLaboral);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExperienciaLaboral>>> GetAllExperienciaLaboral()
        {
            var experienciaLaboral = await _iexperienciaLaboral.GetAllAsync();
            if (experienciaLaboral == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(experienciaLaboral);
        }

        //[Route("listar")]
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ExperienciaLaboral>>> GetAllExperienciaLaboral()
        //{
        //    var experienciaLaboral = await _iexperienciaLaboral.GetAllAsync();
        //    if (experienciaLaboral == null)
        //        return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
        //    return Ok(experienciaLaboral);
        //}

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<ExperienciaLaboral>> GetEXperienciaLaboralbyId(int id)
        {
            var experienciaLaboral = await _iexperienciaLaboral.GetByIdAsync(id);
            //PRUEBA
            if (experienciaLaboral == null)
                return NotFound(new ApiResponse(404));
            return Ok(experienciaLaboral);
        }


        //[Route("Save")]
        //[HttpPost]
        //public async Task<ActionResult<List<ExperienciaLaboralDto>>> SaveEXperienciaLaboral([FromBody] List<ExperienciaLaboral> laborales)
        //{

        //    List<ExperienciaLaboral> ID_EXPERIENCIALABORAL = new List<ExperienciaLaboral>();

        //    foreach (var laboral in laborales)
        //    {
        //        _iexperienciaLaboral.Add(laboral);
        //        await _iexperienciaLaboral.SaveAsync();
        //        if (laboral == null)
        //        {
        //            return BadRequest(new ApiResponse(400));
        //        }
        //        laboral.IdExperienciaLaboral = laboral.IdExperienciaLaboral;
        //        ID_EXPERIENCIALABORAL.Add(new ExperienciaLaboral { IdExperienciaLaboral = laboral.IdExperienciaLaboral });
        //    }

        //    return CreatedAtAction(nameof(SaveEXperienciaLaboral), ID_EXPERIENCIALABORAL);
        //}

        [Route("Save")]
        [HttpPost]
        public bool SaveInfoExperienciaLaboral([FromBody] ExperienciaLaboralDto experienciaLaboraldto)
        {
            return _iexperienciaLaboral.SaveInfoExperienciaLaboral(experienciaLaboraldto);
        }

        //[Route("save")]
        //[HttpPost]
        //public async Task<ActionResult<ExperienciaLaboral>> SaveInfoExperienciaLaboral([FromBody] ExperienciaLaboralDto experienciaLaboraldto)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<ExperienciaLaboralDto, ExperienciaLaboral>();
        //    });
        //    var _mapper = new Mapper(config);
        //    var _experienciaLaboral = _mapper.Map<ExperienciaLaboral>(experienciaLaboraldto);
        //    _iexperienciaLaboral.Add(_experienciaLaboral);
        //    await _iexperienciaLaboral.SaveAsync();
        //    if (experienciaLaboraldto == null)
        //    {
        //        return BadRequest(new ApiResponse(400));
        //    }
        //    experienciaLaboraldto.IdExperienciaLaboral = _experienciaLaboral.IdExperienciaLaboral;
        //    return CreatedAtAction(nameof(SaveInfoExperienciaLaboral), new { IdExperienciaLaboral = experienciaLaboraldto.IdExperienciaLaboral });
        //}

        [Route("Update/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] List<ExperienciaLaboralDto> experienciaLaboraldto)
        {
            return _iexperienciaLaboral.EditInfoExperienciaLaboral(experienciaLaboraldto, id);
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _experienciaLaboral = await _iexperienciaLaboral.GetByIdAsync(id);
            if (_experienciaLaboral == null)
                return NotFound(new ApiResponse(404, "El Empleado que solicita no existe."));

            _iexperienciaLaboral.Remove(_experienciaLaboral);
            await _iexperienciaLaboral.SaveAsync();

            return NoContent();
        }
        //[Route("findByDni/{ced}")]
        //[HttpGet]
        //public async Task<ActionResult<ExperienciaLaboral>> GetfindByDni(string ced)
        //{
        //    var experienciaLaboral = await _iexperienciaLaboral.GetByDniAsync(ced);
        //    if (experienciaLaboral == null)
        //        return NotFound(new ApiResponse(404));
        //    return Ok(experienciaLaboral);
        //}


    }

}