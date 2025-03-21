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
    public class PlanificacionTempController : Controller
    {
        private readonly IPlanificacionTempRepository _iplanificaciontemp;
        private readonly IMapper _mapper;

        public PlanificacionTempController(IPlanificacionTempRepository planificacionTemprepo, IMapper mapper)
        {
            _iplanificaciontemp = planificacionTemprepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanificacionTemp>>> GetAllPlanificacionTemp()
        {
            var campoAmplio = await _iplanificaciontemp.GetAllAsync();
            if (campoAmplio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(campoAmplio);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<PlanificacionTemp>> GetPlanificacionTempbyId(int id)
        {
            var planificacionTemp = await _iplanificaciontemp.GetByIdAsync(id);
            if (planificacionTemp == null)
                return NotFound(new ApiResponse(404));
            return Ok(planificacionTemp);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<PlanificacionTemp>> SavePlanificacionTemp([FromBody] PlanificacionTempDto planificacionTempDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanificacionTempDto, PlanificacionTemp>();
            });
            var _mapper = new Mapper(config);
            var _planificacionTemp = _mapper.Map<PlanificacionTemp>(planificacionTempDto);
            _iplanificaciontemp.Add(_planificacionTemp);
            await _iplanificaciontemp.SaveAsync();
            if (_planificacionTemp == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            planificacionTempDto.IdPlanTemp = _planificacionTemp.IdPlanTemp;
            return CreatedAtAction(nameof(SavePlanificacionTemp), new { IdPlanTemp = planificacionTempDto.IdPlanTemp });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<PlanificacionTempDto>> Put(int id, [FromBody] PlanificacionTempDto planificacionTempDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanificacionTempDto, PlanificacionTemp>();
            });
            var _mapper = new Mapper(config);

            if (planificacionTempDto == null)
                return NotFound(new ApiResponse(404, "La planificacion temporal solicitada no existe."));

            var _planificacionTemp = await _iplanificaciontemp.GetByIdAsync(id);
            if (_planificacionTemp == null)
                return NotFound(new ApiResponse(404, "La planificacion temporal solicitada no existe."));

            var _planificacionTempDto = _mapper.Map<PlanificacionTemp>(planificacionTempDto);
            _iplanificaciontemp.Update(_planificacionTempDto);
            await _iplanificaciontemp.SaveAsync();
            return planificacionTempDto;
        }
        [Route("Edit")]
        [HttpPost]
        public bool EditPlanificacionTemp([FromBody] PlanificacionTempDto planificacionTempDto)
        {
            return _iplanificaciontemp.EditPlanificacion(planificacionTempDto);
        }
    }
}
