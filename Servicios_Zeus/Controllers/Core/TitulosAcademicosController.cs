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
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TitulosAcademicosController : ControllerBase
    {
        private readonly ITitulosAcademicosRepository _irepository;
        private readonly IMapper _mapper;
        public TitulosAcademicosController(ITitulosAcademicosRepository repository, IMapper mapper)
        {
            _irepository = repository;
            _mapper = mapper;
        }

        [Route("getByDni/{identificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TitulosAcademicosDto>>> getByDni(string identificacion)
        {
            var data = await _irepository.getByDni(identificacion);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }
    }
}
