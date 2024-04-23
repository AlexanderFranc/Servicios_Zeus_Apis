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
    [Route("api/capacitacion")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class CapacitacionController : ControllerBase
    {
        private readonly ICapacitacionRepository _icapacitacion;
        private readonly IMapper _mapper;
        public CapacitacionController(ICapacitacionRepository capacitacionrepo, IMapper mapper)
        {
            _icapacitacion = capacitacionrepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<Capacitacion>>> GetAllCapacitacion([FromQuery] Params capacitacionParams)
        {
            var capacitacion = await _icapacitacion.GetAllAsync(capacitacionParams.PageIndex, capacitacionParams.PageSize,
                                    capacitacionParams.Search);
            return new Pager<Capacitacion>(capacitacion.registros, capacitacion.totalRegistros,
            capacitacionParams.PageIndex, capacitacionParams.PageSize, capacitacionParams.Search);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Capacitacion>>> GetAllCapacitacion()
        {
            var capacitacion = await _icapacitacion.GetAllAsync();
            if (capacitacion == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(capacitacion);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Capacitacion>> GetCapacitacionbyId(int id)
        {
            var capacitacion = await _icapacitacion.GetByIdAsync(id);
            if (capacitacion == null)
                return NotFound(new ApiResponse(404));
            return Ok(capacitacion);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<Capacitacion>> GetfindByDni(int id)
        {
            var capacitacion = await _icapacitacion.GetByIdEmpleado(id);
            if (capacitacion == null)
                return NotFound(new ApiResponse(404));
            return Ok(capacitacion);
        }

        [Route("Save")]
        [HttpPost]
        public bool SaveCapacitacion([FromBody] CapacitacionDto capacitaciondto)
        {
            return _icapacitacion.SaveCapacitaciones(capacitaciondto);
        }

        [Route("Update/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] CapacitacionDto capacitaciondto)
        {
            return _icapacitacion.EditCapacitaciones(capacitaciondto, id);
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var capacitacion = await _icapacitacion.GetByIdAsync(id);
            if (capacitacion == null)
                return NotFound(new ApiResponse(404, "La Info. Academica que solicita no existe."));

            _icapacitacion.Remove(capacitacion);
            await _icapacitacion.SaveAsync();

            return NoContent();
        }

    }
}
