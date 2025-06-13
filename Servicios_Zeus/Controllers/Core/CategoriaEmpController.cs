using AutoMapper;
using Core.Entidades.Core;
using Core.Interfaces.Core;
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
    public class CategoriaEmpController : Controller
    {
        private readonly ICategoriaEmpRepository _repository;
        private readonly IMapper _mapper;
        public CategoriaEmpController(ICategoriaEmpRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoContratoN>>> ListarTipoContrato()
        {
            var unidadOrg = await _repository.GetAllAsync();
            if (unidadOrg == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(unidadOrg);
        }
    }
}
