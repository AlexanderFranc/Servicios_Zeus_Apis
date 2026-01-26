﻿using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Core.Interfaces.Generico;
using Infraestructure.Configuration.Zeus.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Servicios_Zeus.Helpers.Errors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicios_Zeus.Controllers.Core
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class AulaController : ControllerBase
    {
        #region Campos Privados (Dependencias)
        private readonly IAulaRepository _aulaRepository;
        private readonly IEspaciosFisicosRepository _repoEspacios;
        private readonly ICampusRepository _repoCampus;
        private readonly IInfraestructuraRepository _repoInfra;
        private readonly INivelInfraestructuraRepository _repoNivel;
        private readonly ITipoEspacioRepository _repoTipo;
        private readonly IEstadoEspacioRepository _repoEstado;
        private readonly IMapper _mapper;
        private readonly ILogger<AulaController> _logger;
        #endregion

        #region Constructor
        public AulaController(
            IAulaRepository aulaRepository,
            IEspaciosFisicosRepository repoEspacios,
            ICampusRepository repoCampus,
            IInfraestructuraRepository repoInfra,
            INivelInfraestructuraRepository repoNivel,
            ITipoEspacioRepository repoTipo,
            IEstadoEspacioRepository repoEstado,
            IMapper mapper,
            ILogger<AulaController> logger)
        {
            _aulaRepository = aulaRepository;
            _repoEspacios = repoEspacios;
            _repoCampus = repoCampus;
            _repoInfra = repoInfra;
            _repoNivel = repoNivel;
            _repoTipo = repoTipo;
            _repoEstado = repoEstado;
            _mapper = mapper;
            _logger = logger;
        }
        #endregion

        #region Endpoints: Ocupación y Listados Generales

        [HttpGet("ocupacion-planificacion-semestral/{idperiodo}/{idespacio}")]
        [ProducesResponseType(typeof(List<HorarioSemestralDto>), StatusCodes.Status200OK)]
        public ActionResult<List<HorarioSemestralDto>> GetOcupacionPlanificacionSemestral(int idperiodo, int idespacio)
        {
            try
            {
                var data = _aulaRepository.GetOcupacionPlanificacionSemestral(idperiodo, idespacio);
                if (data == null) return Ok(new List<HorarioSemestralDto>());
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetOcupacionPlanificacionSemestral");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("getAulas/{activo}")]
        [ProducesResponseType(typeof(List<AulasDto>), StatusCodes.Status200OK)]
        public ActionResult<List<AulasDto>> GetAulas(int activo)
        {
            try
            {
                var data = _aulaRepository.GetAulas(activo);
                if (data == null) return Ok(new List<AulasDto>());
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetAulas");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("listar")]
        [ProducesResponseType(typeof(List<AulasDto>), StatusCodes.Status200OK)]
        public ActionResult<List<AulasDto>> ListarEspacios()
        {
            try
            {
                var items = _aulaRepository.GetAulas(-1);
                if (items == null) return Ok(new List<AulasDto>());
                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en ListarEspacios");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        #endregion

        #region Endpoints: Catálogos (Async)

        [HttpGet("infraestructuras")]
        [ProducesResponseType(typeof(IEnumerable<InfraestructuraDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<InfraestructuraDto>>> GetInfraestructuras()
        {
            try
            {
                var items = await _repoInfra.GetAllAsync();
                if (items == null) return Ok(new List<InfraestructuraDto>());
                return Ok(_mapper.Map<IEnumerable<InfraestructuraDto>>(items));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetInfraestructuras");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("niveles-infraestructura")]
        [ProducesResponseType(typeof(IEnumerable<NivelInfraestructuraDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<NivelInfraestructuraDto>>> GetNivelesInfraestructura()
        {
            try
            {
                var items = await _repoNivel.GetAllAsync();
                if (items == null) return Ok(new List<NivelInfraestructuraDto>());
                return Ok(_mapper.Map<IEnumerable<NivelInfraestructuraDto>>(items));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetNivelesInfraestructura");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("espacios-fisicos-combo")]
        [ProducesResponseType(typeof(IEnumerable<EspaciosFisicosDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EspaciosFisicosDto>>> GetEspaciosFisicosCombo()
        {
            try
            {
                var items = await _repoEspacios.GetAllAsync();
                if (items == null) return Ok(new List<EspaciosFisicosDto>());
                return Ok(_mapper.Map<IEnumerable<EspaciosFisicosDto>>(items));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetEspaciosFisicosCombo");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("tipos-espacio")]
        [ProducesResponseType(typeof(IEnumerable<TipoEspacioDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TipoEspacioDto>>> GetTiposEspacio()
        {
            try
            {
                var items = await _repoTipo.GetAllAsync();
                if (items == null) return Ok(new List<TipoEspacioDto>());
                return Ok(_mapper.Map<IEnumerable<TipoEspacioDto>>(items));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetTiposEspacio");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("estados-espacio")]
        [ProducesResponseType(typeof(List<EstadoEspacioDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<EstadoEspacioDto>>> GetEstadosEspacio()
        {
            try
            {
                var items = await _repoEstado.GetAllAsync();
                
                var result = items != null ? _mapper.Map<List<EstadoEspacioDto>>(items) : new List<EstadoEspacioDto>();

                result.Insert(0, new EstadoEspacioDto 
                {
                    IdEstadoEspacio = 0,
                    NombreEstadoEspacio = " ",
                    Nombre = " ", 
                    Label = " ",
                    Descripcion = "",
                    ActivoEstadoEspacio = true
                });

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetEstadosEspacio");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpGet("campus")]
        [ProducesResponseType(typeof(IEnumerable<CampusDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CampusDto>>> GetCampus()
        {
            try
            {
                var items = await _repoCampus.GetAllAsync();
                if (items == null) return Ok(new List<CampusDto>());
                return Ok(_mapper.Map<IEnumerable<CampusDto>>(items));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en GetCampus");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        #endregion

        #region Endpoints: CRUD Espacios Físicos

        [HttpGet("ver/{id}")]
        [ProducesResponseType(typeof(EspaciosFisicosDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<EspaciosFisicosDto>> VerEspacios(int id)
        {
            try
            {
                var item = await _repoEspacios.GetByIdAsync(id);
                if (item == null) return NotFound(new ApiResponse(404));
                return Ok(_mapper.Map<EspaciosFisicosDto>(item));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en VerEspacios");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpPost("crear")]
        [ProducesResponseType(typeof(EspaciosFisicosDto), StatusCodes.Status201Created)]
        public async Task<ActionResult<EspaciosFisicosDto>> InsertarEspacio([FromBody] EspaciosFisicosDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(new ApiResponse(400));
                
                var entidad = _mapper.Map<EspaciosFisico>(dto);
                _repoEspacios.Add(entidad);
                await _repoEspacios.SaveAsync();

                var resultDto = _mapper.Map<EspaciosFisicosDto>(entidad);
                return CreatedAtAction(nameof(VerEspacios), new { id = entidad.IdEspaciosFisicos }, resultDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en InsertarEspacio");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        [HttpPut("{id}")]
        [HttpPut("editar/{id}")]
        [ProducesResponseType(typeof(EspaciosFisicosDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<EspaciosFisicosDto>> Editar(int id, [FromBody] EspaciosFisicosDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(new ApiResponse(400));

                var actual = await _repoEspacios.GetByIdAsync(id);
                if (actual == null) return NotFound(new ApiResponse(404, "El Espacio Fisico solicitado no existe."));

                _mapper.Map(dto, actual);
                actual.IdEspaciosFisicos = id;

                _repoEspacios.Update(actual);
                await _repoEspacios.SaveAsync();

                return Ok(_mapper.Map<EspaciosFisicosDto>(actual));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en Editar");
                return StatusCode(500, new ApiResponse(500));
            }
        }

        #endregion
    }
}
