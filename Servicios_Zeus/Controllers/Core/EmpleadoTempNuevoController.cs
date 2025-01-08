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
    public class EmpleadoTempNuevoController : ControllerBase
    {
        private IEmpleadoTempNuevoRepository _empleadoTempNuevoRepository;
        private IEmailReporsitory _emailRepo;
        public EmpleadoTempNuevoController(IEmpleadoTempNuevoRepository empleadoTempNuevoRepository, IEmailReporsitory emailRepo)
        {
            _empleadoTempNuevoRepository = empleadoTempNuevoRepository;
            _emailRepo = emailRepo;
        }
        [Route("Agregar")]
        [HttpPost]
        public async Task<ActionResult<EmpleadoTempNuevo>> AgregarEmpleadoTempNuevo([FromBody] EmpleadoTempNuevoDto empleadoTempNuevoDto)
        {
            empleadoTempNuevoDto.FC = DateTime.Now;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmpleadoTempNuevoDto, EmpleadoTempNuevo>();
            });
            var _mapper = new Mapper(config);
            var data = _mapper.Map<EmpleadoTempNuevo>(empleadoTempNuevoDto);
            _empleadoTempNuevoRepository.Add(data);
            await _empleadoTempNuevoRepository.SaveAsync();
            if (empleadoTempNuevoDto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            empleadoTempNuevoDto.IdEmpNuevo = data.IdEmpNuevo;
            return CreatedAtAction(nameof(AgregarEmpleadoTempNuevo), new { IdEmpNuevo = empleadoTempNuevoDto.IdEmpNuevo });
        }

        [Route("UpdateEmpleado/{id}")]
        [HttpPut]
        public bool UpdateEmpleado(int id, [FromBody] EmpleadoTempNuevoDto empleadoTempNuevoDto)
        {
            return _empleadoTempNuevoRepository.EditEmpleadoTempNuevo(empleadoTempNuevoDto, id);
        }
        [HttpPost]
        [Route("sendEmail")]
        public async void SendEmailAsesor([FromBody] EmailDto emaildata)
        {
            await _emailRepo.SendEmail(emaildata);
        }
    }
}
