﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Servicios_Zeus.Helpers.Errors;
using System;
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
    public class MateriaEquivalenteController : Controller
    {
        private readonly IMateriaEquivalenteRepository _materiaEquivalenteRepository;
        private readonly IMateriaEquivalenteGestionRepository _materiaEquivalenteGestionRepository;
        private readonly ILogger<MateriaEquivalenteController> _logger;

        public MateriaEquivalenteController(IMateriaEquivalenteRepository materiaEquivalenteRepository, IMateriaEquivalenteGestionRepository materiaEquivalenteGestionRepository, ILogger<MateriaEquivalenteController> logger)
        {
            _materiaEquivalenteRepository = materiaEquivalenteRepository;
            _materiaEquivalenteGestionRepository = materiaEquivalenteGestionRepository;
            _logger = logger;
        }

        [Route("getPlanificacionEquivalente/{periodo}/{idMallaEquiv}")]
        [HttpGet]
        public ActionResult<IEnumerable<MateriaEquivalenteGestionDto>> getPlanificacionEquivalente(string periodo, int idMallaEquiv)
        {
            _logger.LogInformation($"[MateriaEquivalenteController] getPlanificacionEquivalente called. Periodo={periodo}, IdMallaEquiv={idMallaEquiv}");
            try
            {
                var data = _materiaEquivalenteGestionRepository.getPlanificacionEquivalente(periodo, idMallaEquiv);
                
                if (data == null)
                {
                    _logger.LogWarning("[MateriaEquivalenteController] Data is null.");
                    return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
                }
                
                _logger.LogInformation($"[MateriaEquivalenteController] Data count: {data.Count()}");
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[MateriaEquivalenteController] Error in getPlanificacionEquivalente: {ex.Message} - {ex.StackTrace}");
                return BadRequest(new ApiResponse(400, $"Error interno: {ex.Message}"));
            }
        }

        [Route("getPlanificacionE/{periodo}/{idMallaEquiv}")]
        [HttpGet]
        public ActionResult<IEnumerable<ComponentesPlanificacionDto>> getPlanificacionE(string periodo, int idMallaEquiv)
        {
            var data = _materiaEquivalenteRepository.getPlanificacionE(periodo, idMallaEquiv);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [HttpPost]
        [Route("CrearMateriaEquivalente")]
        public async Task<ActionResult<bool>> CrearMateriaEquivalente([FromBody] MateriaEquivalenteInputDto input)
        {
            _logger.LogInformation($"[MateriaEquivalenteController] CrearMateriaEquivalente called.");
            _logger.LogInformation($"Input: IdMalla={input.IdMalla}, IdMallaEquiv={input.IdMallaEquiv}, Porc={input.PorcEquiv}");
            
            if (input == null)
            {
                 _logger.LogWarning("[MateriaEquivalenteController] Input is null");
                 return BadRequest(new ApiResponse(400, "El input no puede ser nulo"));
            }

            try 
            {
                var result = await _materiaEquivalenteGestionRepository.CrearMateriaEquivalente(input);
                _logger.LogInformation($"[MateriaEquivalenteController] Repo result: {result}");
                
                if (!result) return BadRequest(new ApiResponse(400, "Error al crear la materia equivalente (Repo returned false)"));
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"[MateriaEquivalenteController] Exception: {ex.Message}");
                return BadRequest(new ApiResponse(400, $"Error interno: {ex.Message}"));
            }
        }

        [HttpPut]
        [Route("EditarMateriaEquivalente")]
        public async Task<ActionResult<bool>> EditarMateriaEquivalente([FromBody] MateriaEquivalenteInputDto input)
        {
             _logger.LogInformation($"[MateriaEquivalenteController] EditarMateriaEquivalente called. Id={input.IdMateriaEquivalente}");
             try
             {
                var result = await _materiaEquivalenteGestionRepository.EditarMateriaEquivalente(input);
                if (!result) return BadRequest(new ApiResponse(400, "Error al editar la materia equivalente"));
                return Ok(result);
             }
             catch (Exception ex)
             {
                _logger.LogError($"[MateriaEquivalenteController] Exception: {ex.Message}");
                return BadRequest(new ApiResponse(400, $"Error interno: {ex.Message}"));
             }
        }
    }
}
