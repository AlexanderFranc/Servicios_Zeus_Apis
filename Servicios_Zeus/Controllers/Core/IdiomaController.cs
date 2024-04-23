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
    [Route("api/idioma")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class IdiomaController : ControllerBase
    {
        private readonly IIdiomaRepository _iidioma;
        private readonly IMapper _mapper;
        public IdiomaController(IIdiomaRepository idiomarepo, IMapper mapper)
        {
            _iidioma = idiomarepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<Idioma>>> GetAllIdioma([FromQuery] Params idiomaParams)
        {
            var idioma = await _iidioma.GetAllAsync(idiomaParams.PageIndex, idiomaParams.PageSize,
                                    idiomaParams.Search);
            return new Pager<Idioma>(idioma.registros, idioma.totalRegistros,
            idiomaParams.PageIndex, idiomaParams.PageSize, idiomaParams.Search);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Idioma>>> GetAllIdioma()
        {
            var idioma = await _iidioma.GetAllAsync();
            if (idioma == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(idioma);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Idioma>> GetIdiomabyId(int id)
        {
            var idioma = await _iidioma.GetByIdAsync(id);
            if (idioma == null)
                return NotFound(new ApiResponse(404));
            return Ok(idioma);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<Idioma>> GetfindByDni(int id)
        {
            var idioma = await _iidioma.GetByIdEmpleado(id);
            if (idioma == null)
                return NotFound(new ApiResponse(404));
            return Ok(idioma);
        }

        [Route("Save")]
        [HttpPost]
        public bool SaveIdioma([FromBody] IdiomaDto idiomadto)
        {
            return _iidioma.SaveIdiomas(idiomadto);
        }

        [Route("Update/{id}")]
        [HttpPut]
        public bool Put(int id, [FromBody] IdiomaDto idiomadto)
        {
            return _iidioma.EditIdiomas(idiomadto, id);
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var idioma = await _iidioma.GetByIdAsync(id);
            if (idioma == null)
                return NotFound(new ApiResponse(404, "La Info. Academica que solicita no existe."));

            _iidioma.Remove(idioma);
            await _iidioma.SaveAsync();

            return NoContent();
        }

    }
}
