using Servicios_Zeus.Dtos;
using Infraestructure.Configuration.Zeus.Public;
using Microsoft.AspNetCore.Mvc;
using Core.Interfaces.Public;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servicios_Zeus.Controllers.Public
{
    [Authorize]
    [Route("api/roles")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class RolesController : ControllerBase
    {
        private readonly IRolesUserRepository _iroles;
        public RolesController(IRolesUserRepository rolesuser)
        {
            _iroles = rolesuser;
        }
        [Route("GetByUser/{username}/{nameaplication}")]
        [HttpGet]
        public async Task<ActionResult<UsuarioPerfilDto>> GetRoles(string username,string nameaplication)
        {
            var result = await _iroles.GetRolesUsuario(username, nameaplication);
            return Ok(result);
        }
    }
}
