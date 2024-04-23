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
    [Route("api/proyectoinvestigacion")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ProyectoInvestigacionController : ControllerBase
    {
        private readonly IProyectoInvestigacionRepository _iproyectoinvestigacion;
        private readonly IMapper _mapper;
        public ProyectoInvestigacionController(IProyectoInvestigacionRepository proyectoinvestigacionrepo, IMapper mapper)
        {
            _iproyectoinvestigacion = proyectoinvestigacionrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<ProyectoInvestigacion>>> GetAllProyectoInvestigacion([FromQuery] Params proyectoinvestigacionParams)
        {
            var proyectoinvestigacion = await _iproyectoinvestigacion.GetAllAsync(proyectoinvestigacionParams.PageIndex, proyectoinvestigacionParams.PageSize,
                                    proyectoinvestigacionParams.Search);
            return new Pager<ProyectoInvestigacion>(proyectoinvestigacion.registros, proyectoinvestigacion.totalRegistros,
            proyectoinvestigacionParams.PageIndex, proyectoinvestigacionParams.PageSize, proyectoinvestigacionParams.Search);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProyectoInvestigacion>>> GetAllProyectoInvestigacion()
        {
            var proyectoinvestigacion = await _iproyectoinvestigacion.GetAllAsync();
            if (proyectoinvestigacion == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(proyectoinvestigacion);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<ProyectoInvestigacion>> GetProyectoInvestigacionbyId(int id)
        {
            var proyectoinvestigacion = await _iproyectoinvestigacion.GetByIdAsync(id);
            if (proyectoinvestigacion == null)
                return NotFound(new ApiResponse(404));
            return Ok(proyectoinvestigacion);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<ProyectoInvestigacion>> GetfindByDni(int id)
        {
            var proyectoinvestigacion = await _iproyectoinvestigacion.GetByIdEmpleado(id);
            if (proyectoinvestigacion == null)
                return NotFound(new ApiResponse(404));
            return Ok(proyectoinvestigacion);
        }

        [Route("Save")]
        [HttpPost]
        public bool SaveProyectoInvestigacion([FromBody] List<ProyectoInvestigacionDto> proyectoinvestigaciondto)
        {
            return _iproyectoinvestigacion.SaveProyectoInvestigaciones(proyectoinvestigaciondto);
        }

        [Route("Update/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] List<ProyectoInvestigacionDto> proyectoinvestigaciondto)
        {
            return _iproyectoinvestigacion.EditProyectoInvestigaciones(proyectoinvestigaciondto, id);
        }
    }
}
