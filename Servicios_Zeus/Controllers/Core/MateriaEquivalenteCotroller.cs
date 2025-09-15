using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces;
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
    public class MateriaEquivalenteCotroller : Controller
    {
        private readonly IMateriaEquivalenteRepository _iMateriaEquivalente;
        private readonly IMapper _mapper;
        private IEmailReporsitory _emailRepo;

        public MateriaEquivalenteCotroller(IMateriaEquivalenteRepository materiaequivRepo, IMapper mapper, IEmailReporsitory emailRepo)
        {
            _iMateriaEquivalente = materiaequivRepo;
            _mapper = mapper;
            _emailRepo = emailRepo;
        }

        [Route("getPlanificacionEquivalente/{periodo}/{idMallaEquiv}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudEmpleadoDto>>> getPlanificacionEquivalente(string periodo, int idMallaEquiv)
        {
            var data = _iMateriaEquivalente.getPlanificacionEquivalente(periodo,idMallaEquiv);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("getPlanificacionE/{periodo}/{idMallaEquiv}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComponentesPlanificacionDto>>> getPlanificacionE(string periodo, int idMallaEquiv)
        {
            var data = _iMateriaEquivalente.getPlanificacionE(periodo, idMallaEquiv);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }
    }
}
