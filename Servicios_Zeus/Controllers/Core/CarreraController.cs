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
    [Route("api/carrera")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class CarreraController : ControllerBase
    {
        private readonly ICarreraRepository _irepository;
        private readonly IMapper _mapper;

        public CarreraController(ICarreraRepository carrerarepo, IMapper mapper)
        {
            _irepository = carrerarepo;
            _mapper = mapper;
        }

        [Route("GetAllPaging")]
        [HttpGet]
        public async Task<ActionResult<Pager<Carrera>>> GetAllCarereras([FromQuery] Params carreraParams)
        {
            var carrera = await _irepository.GetAllAsync(carreraParams.PageIndex, carreraParams.PageSize,
                                    carreraParams.Search);
            return new Pager<Carrera>(carrera.registros, carrera.totalRegistros,
            carreraParams.PageIndex, carreraParams.PageSize, carreraParams.Search);
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrera>>> GetAllCarrera()
        {
            var carrera = await _irepository.GetAllAsync();
            if (carrera == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(carrera);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Carrera>> GetCarrerabyId(int id)
        {
            var carrera = await _irepository.GetByIdAsync(id);
            if (carrera == null)
                return NotFound(new ApiResponse(404));
            return Ok(carrera);
        }

        [Route("GetByIdFacultad/{id}")]
        [HttpGet]
        public async Task<ActionResult<Carrera>> GetByIdFacultad(int id)
        {
            var carrera = await _irepository.GetByIdFacultadAsync(id);
            if (carrera == null)
                return NotFound(new ApiResponse(404));
            return Ok(carrera);
        }


        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Carrera>> SaveCarrera([FromBody] CarreraDto carreradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CarreraDto, Carrera>();
            });
            var _mapper = new Mapper(config);
            var _carrera = _mapper.Map<Carrera>(carreradto);
            _irepository.Add(_carrera);
            await _irepository.SaveAsync();
            if (carreradto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            carreradto.IdCarrera = _carrera.IdCarrera;
            return CreatedAtAction(nameof(SaveCarrera), new { IdCarrera = carreradto.IdCarrera });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<CarreraDto>> Put(int id, [FromBody] CarreraDto carreradto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CarreraDto, Carrera>();
            });
            var _mapper = new Mapper(config);

            if (carreradto == null)
                return NotFound(new ApiResponse(404, "La Carrera solicitado no existe."));

            var _carrera = await _irepository.GetByIdAsync(id);
            if (_carrera == null)
                return NotFound(new ApiResponse(404, "La Carrera solicitado no existe."));

            var _carreradto = _mapper.Map<Carrera>(carreradto);
            _irepository.Update(_carreradto);
            await _irepository.SaveAsync();
            return carreradto;
        }
    }
}
