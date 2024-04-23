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
    [Route("api/infoAcademica")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class InfoAcademicaController : ControllerBase
    {
        private readonly IInfoAcademicaRepository _iinfoAcad;
        private readonly IMapper _mapper;

        public InfoAcademicaController(IInfoAcademicaRepository infoacadrepo, IMapper mapper)
        {
            _iinfoAcad = infoacadrepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfoAcademica>>> GetAllInfoAcademica()
        {
            var infoAcad = await _iinfoAcad.GetAllAsync();
            if (infoAcad == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(infoAcad);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<InfoAcademica>> GetInfoAcademicabyId(int id)
        {
            var infoAcad = await _iinfoAcad.GetByIdAsync(id);
            if (infoAcad == null)
                return NotFound(new ApiResponse(404));
            return Ok(infoAcad);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<InfoAcademica>> GetfindByDni(int id)
        {
            var infoAcad = await _iinfoAcad.GetByIdEmpleado(id);
            if (infoAcad == null)
                return NotFound(new ApiResponse(404));
            return Ok(infoAcad);
        }

        [Route("Save")]
        [HttpPost]
        public bool SaveInfoAcademica([FromBody] List<InfoAcademicaDto> infoacademdto)
        {
            return _iinfoAcad.SaveInfoAcademico(infoacademdto);
        }

        [Route("Update/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] List<InfoAcademicaDto> infoacademdto)
        {
            return _iinfoAcad.EditInfoAcademico(infoacademdto, id);
        }




    }
}
