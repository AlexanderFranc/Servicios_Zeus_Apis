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
    public class CampoAmplioController : ControllerBase
    {
        private readonly ICampoAmplioRepository _icampoamplio;
        private readonly IMapper _mapper;

        public CampoAmplioController(ICampoAmplioRepository campoAmpliorepo, IMapper mapper)
        {
            _icampoamplio = campoAmpliorepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampoAmplio>>> GetAllCampoAmplio()
        {
            var campoAmplio = await _icampoamplio.GetAllAsync();
            if (campoAmplio == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(campoAmplio);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<CampoAmplio>> GetCampoAmpliobyId(int id)
        {
            var campoAmplio = await _icampoamplio.GetByIdAsync(id);
            if (campoAmplio == null)
                return NotFound(new ApiResponse(404));
            return Ok(campoAmplio);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<CampoAmplio>> SaveCampoAmplio([FromBody] CampoAmplioDto campoAmpliodto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CampoAmplioDto, CampoAmplio>();
            });
            var _mapper = new Mapper(config);
            var _campoAmplio = _mapper.Map<CampoAmplio>(campoAmpliodto);
            _icampoamplio.Add(_campoAmplio);
            await _icampoamplio.SaveAsync();
            if (campoAmpliodto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            campoAmpliodto.IdCa = _campoAmplio.IdCa;
            return CreatedAtAction(nameof(SaveCampoAmplio), new { IdCa = campoAmpliodto.IdCa });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<CampoAmplioDto>> Put(int id, [FromBody] CampoAmplioDto campoAmpliodto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CampoAmplioDto, CampoAmplio>();
            });
            var _mapper = new Mapper(config);

            if (campoAmpliodto == null)
                return NotFound(new ApiResponse(404, "El Campo Ampliado solicitado no existe."));

            var _campoAmplio = await _icampoamplio.GetByIdAsync(id);
            if (_campoAmplio == null)
                return NotFound(new ApiResponse(404, "El Campo Ampliado solicitado no existe."));

            var _campoAmplioto = _mapper.Map<CampoAmplio>(campoAmpliodto);
            _icampoamplio.Update(_campoAmplioto);
            await _icampoamplio.SaveAsync();
            return campoAmpliodto;
        }
    }
}
