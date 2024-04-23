using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/HorarioSemestral")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class HorarioModularController : ControllerBase
    {
        private readonly IHorarioSemestralRepository _ihoras;
        private readonly IMapper _mapper;
        public HorarioModularController(IHorarioSemestralRepository ihoras, IMapper mapper, IHorario ihorario)
        {
            _ihoras = ihoras;
            _mapper = mapper;
        }
        //int idperiodo,int idperiodicidad,int idmateria,int idsubtipocomponente,int idespacio,string ceduladocente
        [Route("GetHorarioSemestral/{tipohorario}/{idplan}/{idplanificacion}/{idperiodo}/{idperiodicidad}/{idmateria}/{idsubtipocomponente}/{idespacio}/{ceduladocente}")]
        [HttpGet]
        public async Task<ActionResult<List<HorarioSemestralDto>>> GetHorarioModular(string tipohorario, int idplan, int? idplanificacion, int idperiodo, int idperiodicidad, int idmateria, int idsubtipocomponente, int idespacio, string ceduladocente)
        {
            var data = _ihoras.GetHorariosPlanificacionSemestral(tipohorario, idplan, idplanificacion, idperiodo, idperiodicidad, idmateria, idsubtipocomponente, idespacio, ceduladocente);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }
        [Route("Delete/{idplanificacion}/{dia}/{horaI}/{horaF}")]
        [HttpDelete]
        public async Task<ActionResult<Carrera>> DeleteHorarioSemestral(int idplanificacion, int dia, string horaI, string horaF)
        {
            var carrera = _ihoras.DeleteHorarioSemestralPlanificado(idplanificacion, dia, horaI, horaF);
            if (carrera == null)
                return NotFound(new ApiResponse(404));
            return Ok(carrera);
        }


    }
}
