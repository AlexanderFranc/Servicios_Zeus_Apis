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
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class HorarioFechaTempController : Controller
    {
        private readonly IHorarioFechaTempRepository _iFechaTemp;
        private readonly IMapper _mapper;

        public HorarioFechaTempController(IHorarioFechaTempRepository horarioFechaTemp, IMapper mapper)
        {
            _iFechaTemp = horarioFechaTemp;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HorarioFechaTemp>>> GetAllHorarioFechaTemp()
        {
            var horarioFechaTemp = await _iFechaTemp.GetAllAsync();
            if (horarioFechaTemp == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(horarioFechaTemp);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<HorarioFechaTemp>> GetHorarioFechaTempbyId(int id)
        {
            var horarioFechaTemp = await _iFechaTemp.GetByIdAsync(id);
            if (horarioFechaTemp == null)
                return NotFound(new ApiResponse(404));
            return Ok(horarioFechaTemp);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<HorarioFechaTemp>> SaveSolicitud([FromBody] HorarioFechaTempDto horarioFechaDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HorarioFechaTempDto, HorarioFechaTemp>();
            });
            var _mapper = new Mapper(config);
            var _horarioFechaTemp = _mapper.Map<HorarioFechaTemp>(horarioFechaDto);
            _iFechaTemp.Add(_horarioFechaTemp);
            await _iFechaTemp.SaveAsync();
            if (_horarioFechaTemp == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            horarioFechaDto.IdPlanTemp = _horarioFechaTemp.IdPlanTemp;
            return CreatedAtAction(nameof(SaveSolicitud), new { IdPlanTemp = horarioFechaDto.IdPlanTemp });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<HorarioFechaTempDto>> Put(int id, [FromBody] HorarioFechaTempDto horarioFechaTempDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HorarioFechaTempDto, HorarioFechaTemp>();
            });
            var _mapper = new Mapper(config);

            if (horarioFechaTempDto == null)
                return NotFound(new ApiResponse(404, "El horario solicitado no existe."));

            var _horarioFechaTemp = await _iFechaTemp.GetByIdAsync(id);
            if (_horarioFechaTemp == null)
                return NotFound(new ApiResponse(404, "El horario solicitado no existe."));

            var _horarioFechaTempDto = _mapper.Map<HorarioFechaTemp>(horarioFechaTempDto);
            _iFechaTemp.Update(_horarioFechaTempDto);
            await _iFechaTemp.SaveAsync();
            return horarioFechaTempDto;
        }
    }
}
