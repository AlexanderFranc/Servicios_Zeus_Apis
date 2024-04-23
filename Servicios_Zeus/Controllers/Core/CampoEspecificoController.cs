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
    public class CampoEspecificoController : ControllerBase
    {
        private readonly ICampoEspecificoRepository _icampoespe;
        private readonly IMapper _mapper;

        public CampoEspecificoController(ICampoEspecificoRepository campoEsperepo, IMapper mapper)
        {
            _icampoespe = campoEsperepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampoEspecifico>>> GetAllCampoEspecifico()
        {
            var campoEspe = await _icampoespe.GetAllAsync();
            if (campoEspe == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(campoEspe);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<CampoEspecifico>> GetCampoEspecificobyId(int id)
        {
            var campoEspe = await _icampoespe.GetByIdAsync(id);
            if (campoEspe == null)
                return NotFound(new ApiResponse(404));
            return Ok(campoEspe);
        }

        [Route("getByCampAmplio/{idcamp}")]
        [HttpGet]
        public async Task<ActionResult<Infraestructura>> GetByCampAmplio(int idcamp)
        {
            var campoEspe = await _icampoespe.GetByCampoAmplio(idcamp);
            if (campoEspe == null)
                return NotFound(new ApiResponse(404));
            return Ok(campoEspe);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<CampoEspecifico>> SaveCampoEspefico([FromBody] CampoEspecificoDto campespedto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CampoEspecificoDto, CampoEspecifico>();
            });
            var _mapper = new Mapper(config);
            var _campespe = _mapper.Map<CampoEspecifico>(campespedto);
            _icampoespe.Add(_campespe);
            await _icampoespe.SaveAsync();
            if (campespedto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            campespedto.IdCe = _campespe.IdCe;
            return CreatedAtAction(nameof(SaveCampoEspefico), new { IdCe = campespedto.IdCe });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<CampoEspecificoDto>> Put(int id, [FromBody] CampoEspecificoDto campespedto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CampoEspecificoDto, CampoEspecifico>();
            });
            var _mapper = new Mapper(config);

            if (campespedto == null)
                return NotFound(new ApiResponse(404, "El Campo Especificado solicitado no existe."));

            var _campespe = await _icampoespe.GetByIdAsync(id);
            if (_campespe == null)
                return NotFound(new ApiResponse(404, "El Campo Especificado solicitado no existe."));

            var _campespedto = _mapper.Map<CampoEspecifico>(campespedto);
            _icampoespe.Update(_campespedto);
            await _icampoespe.SaveAsync();
            return campespedto;
        }
    }
}
