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
    [Route("api/planificacion1")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class Planificacion1Controller : ControllerBase
    {
        private readonly IPlanificacionRepository1 _irepository;
        private readonly IMapper _mapper;

        public Planificacion1Controller(IPlanificacionRepository1 irepository, IMapper mapper)
        {
            _irepository = irepository;
            _mapper = mapper;
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Planificacion>> Save([FromBody] PlanificacionDto1 planificacionDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanificacionDto1, Planificacion>();
            });
            var _mapper = new Mapper(config);
            var _planificacion = _mapper.Map<Planificacion>(planificacionDto);

            _irepository.Add(_planificacion);
            await _irepository.SaveAsync();
            if (planificacionDto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            planificacionDto.IdPlanificacion = _planificacion.IdPlanificacion;
            return CreatedAtAction(nameof(Save), new { IdPlanificacion = planificacionDto.IdPlanificacion });
        }

        //[Route("Update/{id}")]
        //[HttpPut]
        //public async Task<ActionResult<PlanificacionDto1>> Put(int id, [FromBody] PlanificacionDto1 planificacionDto)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<PlanificacionDto1, Planificacion>();
        //    });
        //    var _mapper = new Mapper(config);

        //    if (planificacionDto == null)
        //        return NotFound(new ApiResponse(404, "La planificación solicitada no existe."));

        //    var _planificacion = await _irepository.GetByIdAsync(id);
        //    if (_planificacion == null)
        //        return NotFound(new ApiResponse(404, "La planificación solicitada no existe."));

        //    var _planificacionDto = _mapper.Map<Planificacion>(planificacionDto);
        //    _irepository.Update(_planificacionDto);
        //    await _irepository.SaveAsync();
        //    return planificacionDto;
        //}
        //CAMBIOS BY LUIS
        [Route("Update/{id}")]
        [HttpPut]
        public void Put([FromBody] PlanificacionDto1 planDto, int id)
        {
            if (planDto != null)
                _irepository.updatehorasPlanificacion(planDto, id);
        }
    }
}
