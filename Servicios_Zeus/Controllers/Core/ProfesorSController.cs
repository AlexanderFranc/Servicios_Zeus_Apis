using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ProfesorSController : ControllerBase
    {
        private readonly IProfesorSRepository _iiprofesors;
        private readonly IMapper _mapper;
        public ProfesorSController(IProfesorSRepository profesorsrepo, IMapper mapper)
        {
            _iiprofesors = profesorsrepo;
            _mapper = mapper;
        }

        [Route("Save")]
        [HttpPost]
        public bool SaveProfesorS([FromBody] ProfesorSDto profesorsDto)
        {
            return _iiprofesors.SaveProfesorS(profesorsDto);
        }

        [Route("GetByIdPlanificacion/{idPlanificacion}")]
        [HttpGet]
        public async Task<ActionResult<ProfesorSDto>> GetByIdPlanificacion(int idPlanificacion)
        {
            var profesors = await _iiprofesors.GetByIdPlanificacion(idPlanificacion);
            if (profesors == null)
                return NotFound(new ApiResponse(404));
            return Ok(profesors);
        }

        [Route("GetAllByIdPlanificacion/{idPlanificacion}")]
        [HttpGet]
        public async Task<ActionResult<ProfesorSDto>> GetAllByIdPlanificacion(int idPlanificacion)
        {
            var profesors = _iiprofesors.GetAllByIdPlanificacion(idPlanificacion);
            if (profesors == null)
                return NotFound(new ApiResponse(404));
            return Ok(profesors);
        }

        [Route("SaveProfesorSList")]
        [HttpPost]
        public bool SaveProfesorSList([FromBody] List<ProfesorSDto> lstProfesorsDto, int idPlanificacion)
        {
            return _iiprofesors.SaveProfesorSList(lstProfesorsDto, idPlanificacion);
        }

        [Route("Delete/{idplanificacion}/{usuario}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProfesorS(int idplanificacion, string usuario)
        {
            var response = _iiprofesors.DeleteProfesorS(idplanificacion,usuario);
            if (response == null)
                return NotFound(new ApiResponse(404));
            return Ok(response);
        }
    }
}
