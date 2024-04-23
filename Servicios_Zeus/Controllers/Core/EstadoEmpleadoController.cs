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
    [Route("api/estado-empleado")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class EstadoEmpleadoController : ControllerBase
    {
        private readonly IEstadoEmpleadoRepository _iestadoemp;
        private readonly IMapper _mapper;

        public EstadoEmpleadoController(IEstadoEmpleadoRepository estadoemprepo, IMapper mapper)
        {
            _iestadoemp = estadoemprepo;
            _mapper = mapper;
        }

        //[Route("listarPage")]
        //[HttpGet]
        //public async Task<ActionResult<Pager<EstadoEmpleado>>> GetAllEstadoEmpleados([FromQuery] Params estadoEmpParams)
        //{
        //    var estadoEmp = await _iestadoemp.GetAllAsync(estadoEmpParams.PageIndex, estadoEmpParams.PageSize,
        //                            estadoEmpParams.Search);
        //    return new Pager<EstadoEmpleado>(estadoEmp.registros, estadoEmp.totalRegistros,
        //    estadoEmpParams.PageIndex, estadoEmpParams.PageSize, estadoEmpParams.Search);
        //}

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadoEmpleado>>> GetAllEstadoEmpleado()
        {
            var estadoEmp = await _iestadoemp.GetAllAsync();
            if (estadoEmp == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(estadoEmp);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<EstadoEmpleado>> GetEstadoEmpById(int id)
        {
            var estadoEmp = await _iestadoemp.GetByIdAsync(id);
            if (estadoEmp == null)
                return NotFound(new ApiResponse(404));
            return Ok(estadoEmp);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<EstadoEmpleado>> SaveEstadoEmp([FromBody] EstadoEmpleadoDto estadoEmpdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EstadoEmpleadoDto, EstadoEmpleado>();
            });
            var _mapper = new Mapper(config);
            var _estadoEmp = _mapper.Map<EstadoEmpleado>(estadoEmpdto);
            _iestadoemp.Add(_estadoEmp);
            await _iestadoemp.SaveAsync();
            if (estadoEmpdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            estadoEmpdto.IdEstadoEmp = _estadoEmp.IdEstadoEmp;
            return CreatedAtAction(nameof(SaveEstadoEmp), new { IdEstadoEmp = estadoEmpdto.IdEstadoEmp });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<EstadoEmpleadoDto>> Put(int id, [FromBody] EstadoEmpleadoDto estadoEmpdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EstadoEmpleadoDto, EstadoEmpleado>();
            });
            var _mapper = new Mapper(config);

            if (estadoEmpdto == null)
                return NotFound(new ApiResponse(404, "El Estado empleado solicitado no existe."));

            var _estadoEmp = await _iestadoemp.GetByIdAsync(id);
            if (_estadoEmp == null)
                return NotFound(new ApiResponse(404, "El Estado empleado solicitado no existe."));

            var _estadoEmpdto = _mapper.Map<EstadoEmpleado>(estadoEmpdto);
            _iestadoemp.Update(_estadoEmpdto);
            await _iestadoemp.SaveAsync();
            return estadoEmpdto;
        }
    }
}
