using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class AulaController : ControllerBase
    {
        private readonly IAulaRepository _iAulaRepository;
        public AulaController(IAulaRepository ihoras)
        {
            _iAulaRepository = ihoras;
        }
        [Route("ocupacion-planificacion-semestral/{idperiodo}/{idespacio}")]
        [HttpGet]
        public async Task<ActionResult<List<HorarioSemestralDto>>> GetOcupacionPlanificacionSemestral(int idperiodo, int idespacio)
        {
            var data = _iAulaRepository.GetOcupacionPlanificacionSemestral(idperiodo, idespacio);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }

        [Route("getAulas/{activo}")]
        [HttpGet]
        public async Task<ActionResult<List<AulasDto>>> GetAulas(int activo)
        {
            var data = _iAulaRepository.GetAulas(activo);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("espacios/listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspaciosFisico>>> ListarEspacios([FromServices] IEspaciosFisicosRepository repo)
        {
            var items = await repo.GetAllAsync();
            if (items == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(items);
        }

        [Route("espacios/ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<EspaciosFisico>> VerEspacio(int id, [FromServices] IEspaciosFisicosRepository repo)
        {
            var item = await repo.GetByIdAsync(id);
            if (item == null)
                return NotFound(new ApiResponse(404));
            return Ok(item);
        }

        [Route("espacios/insertar")]
        [HttpPost]
        public async Task<ActionResult<EspaciosFisico>> InsertarEspacio([FromBody] EspaciosFisicosDto dto, [FromServices] IEspaciosFisicosRepository repo)
        {
            if (dto == null)
                return BadRequest(new ApiResponse(400));
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var mapper = new Mapper(config);
            var entidad = mapper.Map<EspaciosFisico>(dto);
            repo.Add(entidad);
            await repo.SaveAsync();
            dto.IdEspaciosFisicos = entidad.IdEspaciosFisicos;
            return CreatedAtAction(nameof(VerEspacio), new { id = dto.IdEspaciosFisicos });
        }

        [Route("espacios/editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<EspaciosFisicosDto>> EditarEspacio(int id, [FromBody] EspaciosFisicosDto dto, [FromServices] IEspaciosFisicosRepository repo)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var mapper = new Mapper(config);
            if (dto == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));
            var actual = await repo.GetByIdAsync(id);
            if (actual == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));
            var entidad = mapper.Map<EspaciosFisico>(dto);
            entidad.IdEspaciosFisicos = id;
            repo.Update(entidad);
            await repo.SaveAsync();
            return dto;
        }

        [Route("espacios/actualizar/{id}")]
        [HttpPut]
        public async Task<ActionResult<EspaciosFisicosDto>> ActualizarEspacio(int id, [FromBody] EspaciosFisicosDto dto, [FromServices] IEspaciosFisicosRepository repo)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var mapper = new Mapper(config);
            if (dto == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));
            var actual = await repo.GetByIdAsync(id);
            if (actual == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));
            var entidad = mapper.Map<EspaciosFisico>(dto);
            entidad.IdEspaciosFisicos = id;
            repo.Update(entidad);
            await repo.SaveAsync();
            return dto;
        }

        [Route("espacios/leer/{id}")]
        [HttpGet]
        public async Task<ActionResult<EspaciosFisicosDto>> LeerEspacio(int id, [FromServices] IEspaciosFisicosRepository repo)
        {
            var actual = await repo.GetByIdAsync(id);
            if (actual == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisico, EspaciosFisicosDto>();
            });
            var mapper = new Mapper(config);
            var dto = mapper.Map<EspaciosFisicosDto>(actual);
            return Ok(dto);
        }
    }
}
