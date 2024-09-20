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
    public class HorarioTempController : Controller
    {
        private readonly IHorarioTempRepository _iHorarioTemp;
        private readonly IMapper _mapper;

        public HorarioTempController(IHorarioTempRepository horarioTemp, IMapper mapper)
        {
            _iHorarioTemp = horarioTemp;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HorarioTemp>>> GetAllHorarioTemp()
        {
            var horarioTemp = await _iHorarioTemp.GetAllAsync();
            if (horarioTemp == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(horarioTemp);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<HorarioTemp>> GetHorarioTempbyId(int id)
        {
            var horarioTemp = await _iHorarioTemp.GetByIdAsync(id);
            if (horarioTemp == null)
                return NotFound(new ApiResponse(404));
            return Ok(horarioTemp);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<bool>> SaveHorarioTemp([FromBody] HorarioTempDto horarioTempDto)
        {
            bool correcto = _iHorarioTemp.insertHorarioSemestral(horarioTempDto);
            return correcto;
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<HorarioTempDto>> Put(int id, [FromBody] HorarioTempDto horarioTempDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HorarioTempDto, HorarioTemp>();
            });
            var _mapper = new Mapper(config);

            if (horarioTempDto == null)
                return NotFound(new ApiResponse(404, "El horario solicitado no existe."));

            var _horarioTemp = await _iHorarioTemp.GetByIdAsync(id);
            if (_horarioTemp == null)
                return NotFound(new ApiResponse(404, "El horario solicitado no existe."));

            var _horarioTempDto = _mapper.Map<HorarioTemp>(horarioTempDto);
            _iHorarioTemp.Update(_horarioTempDto);
            await _iHorarioTemp.SaveAsync();
            return horarioTempDto;
        }
    }
}
