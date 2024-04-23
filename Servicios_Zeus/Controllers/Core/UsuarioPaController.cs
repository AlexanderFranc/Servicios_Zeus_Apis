using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class UsuarioPaController : ControllerBase
    {
        private readonly IUsuarioPaRepository _irepositoty;
        public UsuarioPaController(IUsuarioPaRepository irepositoty)
        {
            _irepositoty = irepositoty;
        }
        [Route("getAll")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<MateriasPaDto>>> getAll([FromBody] List<UsuarioPaDto> usuarioPaLst)
        {
            var canton = await _irepositoty.GetUsuarioPa(usuarioPaLst);
            if (canton == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(canton);
        }
    }
}
