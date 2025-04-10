using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class MateriasMatriculadasEstudianteController : ControllerBase
    {
        private readonly IMateriasMatriculadasEstudianteRepository _irepository;
        public MateriasMatriculadasEstudianteController(IMateriasMatriculadasEstudianteRepository irepository)
        {
            _irepository = irepository;
        }
        [Route("GetById/{semestre}/{identificacion}/{codcarr}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriasMatriculadasEstudianteDto>>> GetAllMaterias(string semestre, string identificacion, string codcarr)
        {
            var materia = await _irepository.GetMateriasMatriculadasEstudiante(semestre,identificacion,codcarr);
            if (materia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(materia);
        }
        [Route("GetByAC/{semestre}/{malla}/{codmateria}/{identificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriasHorarioEstudianteDto>>> GetByAC(string semestre, string malla, string codmateria, string identificacion)
        {
            var materia = await _irepository.GetMateriasHorarioEstudianteAC(semestre,malla, codmateria,identificacion);
            if (materia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(materia);
        }
        [Route("GetByAPE/{semestre}/{malla}/{codmateria}/{identificacion}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriasHorarioEstudianteDto>>> GetByAPE(string semestre,string malla, string codmateria, string identificacion)
        {
            var materia = await _irepository.GetMateriasHorarioEstudianteAPE(semestre,malla,codmateria, identificacion);
            if (materia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(materia);
        }
        [Route("GetCruceHorario")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<CruceHorarioEstudianteDto>>> GetCruceHorario([FromBody] ParametroEstudianteMatriculadoDto data)
        {
            var materia = await _irepository.GetCruceHorarioEstudiante(data);
            if (materia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(materia);
        }
        [Route("CambiarParalelo")]
        [HttpPost]
        public async Task<ActionResult<bool>> ActualizarParalelo([FromBody] ParametrosActualizarParaleloDto data)
        {
            var materia = await _irepository.CambiarParalelo(data);
            if (materia == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(materia);
        }
    }
}
