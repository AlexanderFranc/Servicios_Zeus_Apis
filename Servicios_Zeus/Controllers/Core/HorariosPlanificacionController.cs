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
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/horariosplanificacion")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class HorariosPlanificacionController : ControllerBase
    {
        private readonly IHorariosPlanificacionRepository _irepository;
        private readonly IMapper _mapper;

        public HorariosPlanificacionController(IHorariosPlanificacionRepository carrerarepo, IMapper mapper)
        {
            _irepository = carrerarepo;
            _mapper = mapper;
        }

        [Route("GetAll/{opcion}/{idperiodo}/{idperiodicidadplanificacion}/{idmateria}/{idtipocomponente}/{idespaciosfisicos}/{codprofe}/{fechaPlanificarIni}/{fechaPlanificarFin}")]
        [HttpGet]   
        public async Task<ActionResult<IEnumerable<HorariosPlanificacionDto>>> GetAll(string opcion, int idperiodo, int idperiodicidadplanificacion, int idmateria, int idtipocomponente, int idespaciosfisicos, string codprofe, string? fechaPlanificarIni, string? fechaPlanificarFin)
        {
            var carrera =  _irepository.GetHorariosPlanificacionSemanal(opcion,idperiodo, idperiodicidadplanificacion, idmateria,idtipocomponente,idespaciosfisicos,codprofe,fechaPlanificarIni,fechaPlanificarFin);
            if (carrera == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(carrera);
        }

        [Route("GetDetalleCruce/{id}")]
        [HttpGet]
        public async Task<ActionResult<string>> GetDetalleCruce(string id)
        {
            var carrera = _irepository.GetDescripcionCruce(id);
            if (carrera == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(carrera);
        }
    }
}
