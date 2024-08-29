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
using Microsoft.Extensions.Options;


namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class SolicitudController : Controller
    {
        private readonly ISolicitudRepository _iSolicitud;
        private readonly IMapper _mapper;

        public SolicitudController(ISolicitudRepository solicitudRepo, IMapper mapper)
        {
            _iSolicitud = solicitudRepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Solicitud>>> GetAllSolicitud()
        {
            var solicitud = await _iSolicitud.GetAllAsync();
            if (solicitud == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(solicitud);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Solicitud>> GetSolicitudTempbyId(int id)
        {
            var solicitud = await _iSolicitud.GetByIdAsync(id);
            if (solicitud == null)
                return NotFound(new ApiResponse(404));
            return Ok(solicitud);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Solicitud>> SaveSolicitud([FromBody] SolicitudDto solicitudDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SolicitudDto, Solicitud>();
            });
            var _mapper = new Mapper(config);
            var _solicitud = _mapper.Map<Solicitud>(solicitudDto);
            _iSolicitud.Add(_solicitud);
            await _iSolicitud.SaveAsync();
            if (_solicitud == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            solicitudDto.IdSolicitud = _solicitud.IdSolicitud;
            return CreatedAtAction(nameof(SaveSolicitud), new { IdSolicitud = solicitudDto.IdSolicitud });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<SolicitudDto>> Put(int id, [FromBody] SolicitudDto solicitudDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SolicitudDto, Solicitud>();
            });
            var _mapper = new Mapper(config);

            if (solicitudDto == null)
                return NotFound(new ApiResponse(404, "La solicitud no existe."));

            var _solicitud = await _iSolicitud.GetByIdAsync(id);
            if (_solicitud == null)
                return NotFound(new ApiResponse(404, "La solicitud no existe."));

            var _solicitudDto = _mapper.Map<Solicitud>(solicitudDto);
            _iSolicitud.Update(_solicitudDto);
            await _iSolicitud.SaveAsync();
            return solicitudDto;
        }
      
        //[Route("getSolicitudes/{opcion}/{tipo}/{periodo}/{codfac}/{codcar}/{estado}")]
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudes(string opcion, string tipo, string periodo, string codfac, string codcar, string estado)
        //{
        //    var data = _iSolicitud.getSolicitudes(opcion, tipo, periodo, codfac, codcar, estado);
        //    if (data == null)
        //        return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
        //    return Ok(data);
        //}

        [Route("getSolicitudPlanificacion/{idperiodo}/{idplanestudio}/{idmodalidadplanificacio}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudPlanificacion(int idperiodo, int idplanestudio, int idmodalidadplanificacio)
        {
            var data = _iSolicitud.getSolicitudPlanificacion(idperiodo,idplanestudio,idmodalidadplanificacio);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        
    }
}
