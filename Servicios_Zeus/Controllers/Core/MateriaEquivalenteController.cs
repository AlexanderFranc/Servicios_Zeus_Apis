﻿using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;
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

        public MateriaEquivalenteController(IMateriaEquivalenteRepository materiaEquivalenteRepository)
        {
            _materiaEquivalenteRepository = materiaEquivalenteRepository;
        }

        [Route("getPlanificacionEquivalente/{periodo}/{idMallaEquiv}")]
        [HttpGet]
        public ActionResult<IEnumerable<MateriaEquivalenteDto>> getPlanificacionEquivalente(string periodo, int idMallaEquiv)
        {
            Console.WriteLine($"[MateriaEquivalenteController] getPlanificacionEquivalente called. Periodo={periodo}, IdMallaEquiv={idMallaEquiv}");
            try
            {
                var data = _materiaEquivalenteRepository.getPlanificacionEquivalente(periodo, idMallaEquiv);
                
                if (data == null)
                {
                    Console.WriteLine("[MateriaEquivalenteController] Data is null.");
                    return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
                }
                
                Console.WriteLine($"[MateriaEquivalenteController] Data count: {data.Count()}");
                return Ok(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MateriaEquivalenteController] Error in getPlanificacionEquivalente: {ex.Message} - {ex.StackTrace}");
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
            Console.WriteLine($"[MateriaEquivalenteController] CrearMateriaEquivalente called.");
            Console.WriteLine($"Input: IdMalla={input.IdMalla}, IdMallaEquiv={input.IdMallaEquiv}, Porc={input.PorcEquiv}");
            
            if (input == null)
            {
                 Console.WriteLine("[MateriaEquivalenteController] Input is null");
                 return BadRequest(new ApiResponse(400, "El input no puede ser nulo"));
            }

            try 
            {
                var result = await _materiaEquivalenteRepository.CrearMateriaEquivalente(input);
                Console.WriteLine($"[MateriaEquivalenteController] Repo result: {result}");
                
                if (!result) return BadRequest(new ApiResponse(400, "Error al crear la materia equivalente (Repo returned false)"));
                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MateriaEquivalenteController] Exception: {ex.Message}");
                return BadRequest(new ApiResponse(400, $"Error interno: {ex.Message}"));
            }
        }

        [HttpPut]
        [Route("EditarMateriaEquivalente")]
        public async Task<ActionResult<bool>> EditarMateriaEquivalente([FromBody] MateriaEquivalenteInputDto input)
        {
             Console.WriteLine($"[MateriaEquivalenteController] EditarMateriaEquivalente called. Id={input.IdMateriaEquivalente}");
             try
             {
                var result = await _materiaEquivalenteRepository.EditarMateriaEquivalente(input);
                if (!result) return BadRequest(new ApiResponse(400, "Error al editar la materia equivalente"));
                return Ok(result);
             }
             catch (Exception ex)
             {
                Console.WriteLine($"[MateriaEquivalenteController] Exception: {ex.Message}");
                return BadRequest(new ApiResponse(400, $"Error interno: {ex.Message}"));
             }
        }
    }
}
