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
    [Route("api/HorasFranjaHoraria")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class HorasFranjaHorariaController : ControllerBase
    {
        private readonly IHorario _ihorario;
        private readonly IHorasFranjaHoraria _ihoras;
        private readonly IMapper _mapper;
        public HorasFranjaHorariaController(IHorasFranjaHoraria ihoras, IMapper mapper, IHorario ihorario)
        {
            _ihoras = ihoras;
            _mapper = mapper;
            _ihorario = ihorario;
        }
        [Route("GetAllByIdPlan/{id}")]
        [HttpGet]
        public async Task<ActionResult<List<HorasFranjaHorariaDto>>> GetAll(int id)
        {
            var data =  _ihoras.GetHorasFranjaHoraria(id);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }
        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<List<HorarioInsertDto>>> SaveHorarios([FromBody] List<HorarioDto> horarios)
        {

            List<HorarioInsertDto> ID_PLANIFICACION = new List<HorarioInsertDto>();

            foreach (var horario in horarios)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<HorarioDto, Horario>();
                });

                var _mapper = new Mapper(config);
                var _horario = _mapper.Map<Horario>(horario);
                _ihorario.Add(_horario);
                await _ihorario.SaveAsync();
                if (horario == null)
                {
                    return BadRequest(new ApiResponse(400));
                }
                //horario.IdPlanificacion = _horario.IdPlanificacion;
                ID_PLANIFICACION.Add(new HorarioInsertDto {  });
            }

            return CreatedAtAction(nameof(SaveHorarios), ID_PLANIFICACION);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {

            string message = _ihoras.EliminarHorasFranjaHoraria(id);

            return Ok(message);
        }
    }
}
