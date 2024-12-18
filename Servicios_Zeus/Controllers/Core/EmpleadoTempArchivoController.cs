using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoTempArchivoController : ControllerBase
    {
        private IEmpleadoTempArchivoRepository _empleadoTempArchivo;
        public EmpleadoTempArchivoController(IEmpleadoTempArchivoRepository empleadoTempArchivo)
        {
            _empleadoTempArchivo = empleadoTempArchivo;
        }
        [Route("Agregar")]
        [HttpPost]
        public async Task<ActionResult<EmpleadoTempArchivo>> AgregarEmpleadoTempArchivo(EmpleadoTempArchivoDto empleadoTempArchivoDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmpleadoTempArchivoDto, EmpleadoTempArchivo>();
            });
            var _mapper = new Mapper(config);
            var data = _mapper.Map<EmpleadoTempArchivo>(empleadoTempArchivoDto);
            _empleadoTempArchivo.Add(data);
            await _empleadoTempArchivo.SaveAsync();
            if (empleadoTempArchivoDto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            empleadoTempArchivoDto.Id = data.Id;
            return CreatedAtAction(nameof(AgregarEmpleadoTempArchivo), new { Id = empleadoTempArchivoDto.Id });
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<EmpleadoTempArchivo>> GetArchivosEmpNuevobyId(int id)
        {
            var emp = await _empleadoTempArchivo.GetByIdAsync(id);
            if (emp == null)
                return NotFound(new ApiResponse(404));
            return Ok(emp);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<EmpleadoTempArchivo>> GetfindByIdEmpN(int id)
        {
            var idioma = await _empleadoTempArchivo.GetfindByIdEmpN(id);
            if (idioma == null)
                return NotFound(new ApiResponse(404));
            return Ok(idioma);
        }
    }
}
