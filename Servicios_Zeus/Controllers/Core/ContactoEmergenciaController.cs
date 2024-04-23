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
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ContactoEmergenciaController : ControllerBase
    {
        private readonly IContactoEmergenciaRepository _icontacto;
        private readonly IMapper _mapper;

        public ContactoEmergenciaController(IContactoEmergenciaRepository contactorepo, IMapper mapper)
        {
            _icontacto = contactorepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactoEmergencium>>> GetAllContactoEmerg()
        {
            var contacto = await _icontacto.GetAllAsync();
            if (contacto == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(contacto);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<ContactoEmergencium>> GetContactoEmergbyId(int id)
        {
            var contacto = await _icontacto.GetByIdAsync(id);
            if (contacto == null)
                return NotFound(new ApiResponse(404));
            return Ok(contacto);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<ContactoEmergencium>> GetfindByDni(int id)
        {
            var contacto = await _icontacto.GetByIdEmpleado(id);
            if (contacto == null)
                return NotFound(new ApiResponse(404));
            return Ok(contacto);
        }
        [Route("delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _emp = await _icontacto.GetByIdAsync(id);
            if (_emp == null)
                return NotFound(new ApiResponse(404, "El Empleado que solicita no existe."));

            _icontacto.Remove(_emp);
            await _icontacto.SaveAsync();

            return NoContent();
        }

        [Route("Save")]
        [HttpPost]
        public bool SaveContactoEmerg([FromBody] ContactoEmergencium contactoEmergdto)
        {
            return _icontacto.SaveContactoEmergencia(contactoEmergdto);
        }
    }
}
