using AutoMapper;
using Core.Dtos.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class SilaboMateriasUsuarioController : ControllerBase
    {
        private readonly ISilaboMateriasUsuarioRepository _irepository;
        public SilaboMateriasUsuarioController(ISilaboMateriasUsuarioRepository irepository)
        {
            _irepository = irepository;
        }

        [Route("getAll/{periodo}/{identificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SilaboMateriasUsuarioDto>>> getAll(string periodo,string identificacion)
        {
            var data = await _irepository.GetAll(periodo, identificacion);
            if (data == null)
                return NotFound(new ApiResponse(404));
            return Ok(data);
        }
    }
}
