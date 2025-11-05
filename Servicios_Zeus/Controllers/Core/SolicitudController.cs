using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;
using System.Collections.Generic;


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
        private IEmailReporsitory _emailRepo;


        public SolicitudController(ISolicitudRepository solicitudRepo, IMapper mapper, IEmailReporsitory emailRepo)
        {
            _iSolicitud = solicitudRepo;
            _mapper = mapper;
            _emailRepo = emailRepo;
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
            try
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<SolicitudDto, Solicitud>();
                });
                solicitudDto.FechaSolicitud = DateTime.Now;
                solicitudDto.FC = DateTime.Now;
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("SaveSolicitudPlanEmp")]
        [HttpPost]
        public bool SaveSolicitudPlanEmp([FromBody] SaveSolicitudPlanEmpDto saveSolicitudPlanEmpDto)
        {
            return _iSolicitud.SaveSolicitudPlanEmp(saveSolicitudPlanEmpDto.lstSolicitudDto, saveSolicitudPlanEmpDto.idEmpleadoNuevo, saveSolicitudPlanEmpDto.lstProfesorSDto);
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

        [Route("getSolicitudPlanificacion/{idperiodo}/{idplanestudio}/{idmodalidadplanificacio}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudPlanificacion(int idperiodo, int idplanestudio, int idmodalidadplanificacio)
        {
            var data = _iSolicitud.getSolicitudPlanificacion(idperiodo,idplanestudio,idmodalidadplanificacio);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("getSolicitudPlanificacionEquivalente/{idperiodo}/{idplanestudio}/{idmodalidadplanificacio}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudPlanificacionEquivalente(int idperiodo, int idplanestudio, int idmodalidadplanificacio)
        {
            var data = _iSolicitud.getSolicitudPlanificacionEquivalente(idperiodo, idplanestudio, idmodalidadplanificacio);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("getSolicitudPlanificacionVice/{idperiodo}/{idfacultad}/{idcarrera}/{estado}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudPlanificacionVice(int idperiodo, int idfacultad, int idcarrera, string estado)
        {
            var data = _iSolicitud.getSolicitudPlanificacionVice(idperiodo, idfacultad, idcarrera, estado);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }
        [Route("getSolicitudNuevoEmp/{idperiodo}/{idfacultad}/{estado}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudEmpleadoDto>>> getSolicitudNuevoEmp(int idperiodo, int idfacultad, string estado)
        {
            var data = _iSolicitud.getSolicitudNuevoEmp(idperiodo, idfacultad, estado);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("getSolicitudPlanificacionNuevoEmp/{idEmpleadoN}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudPlanificacionNuevoEmp(int idEmpleadoN)
        {
            var data = _iSolicitud.getSolicitudPlanificacionNuevoEmp(idEmpleadoN);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("getNuevoEmp/{idEmpleadoN}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpleadoTempNuevoDto>>> getNuevoEmp(int idEmpleadoN)
        {
            var data = _iSolicitud.getNuevoEmp(idEmpleadoN);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("getSolicitudPlanificacionTH/{idperiodo}/{idfacultad}/{idcarrera}/{estado}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SolicitudPlanificacionDto>>> getSolicitudPlanificacionTH(int idperiodo, int idfacultad, string estado)
        {
            var data = _iSolicitud.getSolicitudPlanificacionTH(idperiodo, idfacultad, estado);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }

        [Route("GetHorarioSemestral/{tipohorario}/{idplan}/{idSolicitud}/{idperiodo}/{idperiodicidad}/{idmateria}/{idsubtipocomponente}/{idespacio}/{ceduladocente}")]
        [HttpGet]
        public async Task<ActionResult<List<HorarioSemestralDto>>> GetHorarioSolicitud(string tipohorario, int idplan, int? idSolicitud, int idperiodo, int idperiodicidad, int idmateria, int idsubtipocomponente, int idespacio, string ceduladocente)
        {
            var data = _iSolicitud.GetHorarioSolicitud(tipohorario, idplan, idSolicitud, idperiodo, idperiodicidad, idmateria, idsubtipocomponente, idespacio, ceduladocente);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(data);
        }

        [Route("UpdateEstado/{id}")]
        [HttpPut]
        public bool UpdateEstado(int id, [FromBody] SolicitudDto solicitudDto)
        {
            return _iSolicitud.EditSolicitudEstado(solicitudDto, id);
        }
        [Route("UpdateEstadoEmp/{id}")]
        [HttpPut]
        public bool UpdateEstadoEmp(int id, [FromBody] SolicitudEmpleadoDto solicitudEmpleadoDto)
        {
            return _iSolicitud.EditSolicitudEmpleadoEstado(solicitudEmpleadoDto, id);
        }

        [Route("getLogObservacionesSolicitudNEmp/{idEmpNuevo}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpNuevoObservacionLogDto>>> getLogObservacionesSolicitudNEmp(int idEmpNuevo)
        {
            var data = _iSolicitud.getLogObservacionesSolicitudNEmp(idEmpNuevo);
            if (data == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún item."));
            return Ok(data);
        }
        [Route("enviarCorreoCambioPlanificacion")]
        [HttpPost]
        public async void enviarCorreoCambioPlanificacion([FromBody] EmailSolicitudPlanificacionDto body)
        {
            await _emailRepo.CorreoCambioPlanificacion(body);
        }
        [Route("editarSolicitud")]
        [HttpPost]
        public bool editarSolicitud([FromBody] SolicitudDto solicitudDto)
        {
            return _iSolicitud.EditSolicitud(solicitudDto);
        }
    }
}
