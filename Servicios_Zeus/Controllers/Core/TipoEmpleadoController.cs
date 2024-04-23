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
    [Route("api/tipo-empleado")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoEmpleadoController : ControllerBase
    {
        private readonly ITipoEmpleadoRepository _itipoEmp;
        private readonly IMapper _mapper;

        public TipoEmpleadoController(ITipoEmpleadoRepository tipoEmprepo, IMapper mapper)
        {
            _itipoEmp = tipoEmprepo;
            _mapper = mapper;
        }

        //[Route("listarPage")]
        //[HttpGet]
        //public async Task<ActionResult<Pager<TipoEmpleado>>> GetAllTiposEmpleados([FromQuery] Params tipoEmpParams)
        //{
        //    var tipoEmp = await _itipoEmp.GetAllAsync(tipoEmpParams.PageIndex, tipoEmpParams.PageSize,
        //                            tipoEmpParams.Search);
        //    return new Pager<TipoEmpleado>(tipoEmp.registros, tipoEmp.totalRegistros,
        //    tipoEmpParams.PageIndex, tipoEmpParams.PageSize, tipoEmpParams.Search);
        //}

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEmpleado>>> GetAllTipoEmpleado()
        {
            var tipoEmp = await _itipoEmp.GetAllAsync();
            if (tipoEmp == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoEmp);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoEmpleado>> GetTipoEmpleadobyId(int id)
        {
            var tipoEmp = await _itipoEmp.GetByIdAsync(id);
            if (tipoEmp == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipoEmp);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<TipoEmpleado>> SaveTipoEmp([FromBody] TipoEmpleadoDto tipoempldto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoEmpleadoDto, TipoEmpleado>();
            });
            var _mapper = new Mapper(config);
            var _tipoempl = _mapper.Map<TipoEmpleado>(tipoempldto);
            _itipoEmp.Add(_tipoempl);
            await _itipoEmp.SaveAsync();
            if (tipoempldto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipoempldto.IdTipoEmp = _tipoempl.IdTipoEmp;
            return CreatedAtAction(nameof(SaveTipoEmp), new { IdTipoEmp = tipoempldto.IdTipoEmp });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoEmpleadoDto>> Put(int id, [FromBody] TipoEmpleadoDto tipoempldto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoEmpleadoDto, TipoEmpleado>();
            });
            var _mapper = new Mapper(config);

            if (tipoempldto == null)
                return NotFound(new ApiResponse(404, "El Tipo de Empleado solicitado no existe."));

            var _tipoempl = await _itipoEmp.GetByIdAsync(id);
            if (_tipoempl == null)
                return NotFound(new ApiResponse(404, "El Tipo de Empleado solicitado no existe."));

            var _tipoempldto = _mapper.Map<TipoEmpleado>(tipoempldto);
            _itipoEmp.Update(_tipoempldto);
            await _itipoEmp.SaveAsync();
            return tipoempldto;
        }
    }
}
