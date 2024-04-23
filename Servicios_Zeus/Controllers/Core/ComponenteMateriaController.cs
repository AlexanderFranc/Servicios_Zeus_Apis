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
    [Route("api/componentemateria")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ComponenteMateriaController : ControllerBase
    {
        private readonly IMateriaComponenteRepository _icomponente;
        private readonly IMapper _mapper;
        public ComponenteMateriaController(IMateriaComponenteRepository componenterepo, IMapper mapper)
        {
            _icomponente = componenterepo;
            _mapper = mapper;
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriaComponenteDto>>> GetAll()
        {
            var componentemateria = await _icomponente.getAllMateriaComponentes();
            if (componentemateria == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(componentemateria);
        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<MateriaComponenteDto>>> GetAllMaterias([FromQuery] Params parametros)
        {
            var materia = await _icomponente.GetAllPagingAsync(parametros.PageIndex, parametros.PageSize,
                                    parametros.Search);
            return new Pager<MateriaComponenteDto>(materia.registros, materia.totalRegistros,
            parametros.PageIndex, parametros.PageSize, parametros.Search);
        }

        [Route("GetAllByMateria/{codplan}/{idmateria}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriaComponenteDto>>> GetAllByMateria(string codplan, int idmateria)
        {
            var componentemateria = await _icomponente.getAllMateriaComponentesByPlan(codplan, idmateria);
            if (componentemateria == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(componentemateria);
        }
        [Route("Update")]
        [HttpPut]
        public void Put([FromBody] ComponenteMateriaMallaDto[] componente)
        {
            if (componente != null)
                _icomponente.updatehorasComponente(componente);
        }
        [Route("GetComponenteSinPlanificar/{idPlanEstudio}/{idMateria}/{idPeriodo}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriaComponenteDto>>> getComponenteSinPlanificar(int idPlanEstudio, int idMateria, int idPeriodo)
        {
            var componentemateria = await _icomponente.getComponenteSinPlanificar(idPlanEstudio, idMateria, idPeriodo);
            if (componentemateria == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(componentemateria);
        }
        [Route("GetAllComponenteSinPlanificar/{idPlanEstudio}/{idPeriodo}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriaComponenteDto>>> getAllComponenteSinPlanificar(int idPlanEstudio, int idPeriodo)
        {
            var componentemateria = await _icomponente.getAllComponenteSinPlanificar(idPlanEstudio, idPeriodo);
            if (componentemateria == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(componentemateria);
        }

    }
}
