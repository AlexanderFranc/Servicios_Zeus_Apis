
using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        // 1. Declaramos las variables para AMBOS repositorios
        private readonly IAulaRepository _iAulaRepository;
        private readonly IEspaciosFisicosRepository _repoEspacios;

        // 2. En el constructor recibimos AMBOS e inicializamos las variables
        public AulaController(IAulaRepository ihoras, IEspaciosFisicosRepository repoEspacios)
        {
            _iAulaRepository = ihoras;
            _repoEspacios = repoEspacios;
        }

        // --- MÉTODOS ORIGINALES (AULA) ---

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

        // --- CRUD DE ESPACIOS FÍSICOS (Usando _repoEspacios) ---

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspaciosFisico>>> ListarEspacios()
        {
            var items = await _repoEspacios.GetAllAsync();
            if (items == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(items);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<EspaciosFisico>> VerEspacios(int id)
        {
            var item = await _repoEspacios.GetByIdAsync(id);
            if (item == null)
                return NotFound(new ApiResponse(404));
            return Ok(item);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<EspaciosFisico>> InsertarEspacio([FromBody] EspaciosFisicosDto dto)
        {
            if (dto == null)
                return BadRequest(new ApiResponse(400));

            // Configuración del Mapper local como pediste
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var mapper = new Mapper(config);

            var entidad = mapper.Map<EspaciosFisico>(dto);

            _repoEspacios.Add(entidad);
            await _repoEspacios.SaveAsync();

            dto.IdEspaciosFisicos = entidad.IdEspaciosFisicos;

            return CreatedAtAction(nameof(VerEspacios), new { id = dto.IdEspaciosFisicos }, entidad);
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<EspaciosFisicosDto>> Editar(int id, [FromBody] EspaciosFisicosDto dto)
        {
            if (dto == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));

            var actual = await _repoEspacios.GetByIdAsync(id);
            if (actual == null)
                return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EspaciosFisicosDto, EspaciosFisico>();
            });
            var mapper = new Mapper(config);

            var entidad = mapper.Map<EspaciosFisico>(dto);
            entidad.IdEspaciosFisicos = id;

            _repoEspacios.Update(entidad);
            await _repoEspacios.SaveAsync();

            return dto;
        }
    }
}
