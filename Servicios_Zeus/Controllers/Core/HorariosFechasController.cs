using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;
using System.Threading.Tasks;

namespace Servicios_Zeus.Controllers.Core
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/HorarioFechas")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class HorariosFechasController : ControllerBase
    {

        private readonly IHorarioRepository _ihorario;
        private readonly IMapper _mapper;
        public HorariosFechasController(IHorarioRepository horariorepo, IMapper mapper)
        {
            _ihorario = horariorepo;
            _mapper = mapper;
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<List<HorarioFechaDto>>> SaveHorarios([FromBody] List<HorarioFecha> horarios)
        {

            List<HorarioFecha> ID_PLANIFICACION = new List<HorarioFecha>();

            foreach (var horario in horarios)
            {
                _ihorario.Add(horario);
                await _ihorario.SaveAsync();
                if (horario == null)
                {
                    return BadRequest(new ApiResponse(400));
                }
                horario.IdPlanificacion = horario.IdPlanificacion;
                ID_PLANIFICACION.Add(new HorarioFecha { IdPlanificacion = horario.IdPlanificacion });
            }

            return CreatedAtAction(nameof(SaveHorarios), ID_PLANIFICACION);
        }
        [Route("GetAll/{idplanestudio}/{idperiodo}/{idmodalidad}/{dniprofesor}/{idtipocomponente}/{paralelo}/{idespaciofisico}/{idmateria}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HorarioFecha>>> GetAll(int idplanestudio, int idperiodo, int idmodalidad, string dniprofesor, int idtipocomponente, string paralelo, int idespaciofisico, int idmateria)
        {
            var carrera = await _ihorario.GetAll(idplanestudio, idperiodo, idmodalidad, dniprofesor, idtipocomponente, paralelo, idespaciofisico, idmateria);
            if (carrera == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(carrera);
        }

        [Route("SaveHorarioFechasModular/{idplanificacion}")]
        [HttpPost]
        public bool SaveHorarioModular(int idplanificacion, [FromBody] List<HorarioModularDto> horariomodular)
        {
            bool correcto = _ihorario.insertHorarioModular(idplanificacion, horariomodular);
            return correcto;
        }
        [Route("SaveHorarioSemestral/{idplanificacion}")]
        [HttpPost]
        public bool SaveHorarioSemestral(int idplanificacion, [FromBody] List<HorarioDto> horariosemestral)
        {
            bool correcto = _ihorario.insertHorarioSemestral(idplanificacion, horariosemestral);
            return correcto;
        }

        [Route("GetHorarioFechasPlanificado/{idplanificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HorarioModularDto>>> GetHorarioFechasPlanificado(int idplanificacion)
        {
            var data = _ihorario.GetHorarioFechasPlanificado(idplanificacion);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);

        }
        [Route("GetHorarioModularPlanificado/{idplanificacion}")]
        [HttpGet]
        public async Task<ActionResult<List<HorarioModularDto>>> GetHorarioModularPlanificado(int idplanificacion)
        {
            var data = _ihorario.GetHorarioModularPlanificado(idplanificacion);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);

        }

        [Route("delete/{idplanificacion}/{horaI}/{horaF}")]
        [HttpGet]
        public async Task<ActionResult<List<HorarioModularDto>>> GetHorarioModularPlanificado(int idplanificacion,string horaI,string horaF)
        {
            var data = _ihorario.delete(idplanificacion, horaI, horaF);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);

        }
    }
}
