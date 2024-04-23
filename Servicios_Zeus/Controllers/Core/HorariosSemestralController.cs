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
    [Route("api/HorariosSemestrales")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class HorariosSemestralController : ControllerBase
    {
        private readonly IHorarioSemestralPlanificadoRepository _horarioSemestralPlanificadoRepository;
        private readonly IHorariosSemestralRepository _irepository;
        private readonly IMapper _mapper;

        public HorariosSemestralController(IHorariosSemestralRepository repository, IHorarioSemestralPlanificadoRepository horarioSemestralPlanificadoRepository, IMapper mapper)
        {
            _irepository = repository;
            _mapper = mapper;
            _horarioSemestralPlanificadoRepository = horarioSemestralPlanificadoRepository;
        }


        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Carrera>> GetHorarioSemestral(int id)
        {
            var carrera = await _irepository.GetByPlanificacionAsync(id);
            if (carrera == null)
                return NotFound(new ApiResponse(404));
            return Ok(carrera);
        }

        [Route("GetHorarioPlanificado/{id}")]
        [HttpGet]
        public async Task<ActionResult<Carrera>> GetHorarioPlanificado(int id)
        {
            var carrera = await _horarioSemestralPlanificadoRepository.getHorarioSemestralPlanificado(id);
            if (carrera == null)
                return NotFound(new ApiResponse(404));
            return Ok(carrera);
        }


    }
}
