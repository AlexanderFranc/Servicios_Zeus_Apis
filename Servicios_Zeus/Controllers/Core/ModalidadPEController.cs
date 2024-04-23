using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/modalidadpe")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ModalidadPEController : ControllerBase
    {
        private readonly IModalidadPE _imodalidadpe;
        private readonly IMapper _mapper;
        
        public ModalidadPEController(IModalidadPE modalidadperepo, IMapper mapper)
        {
            _imodalidadpe = modalidadperepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]

        public async Task<ActionResult<Pager<ModalidadPe>>> GetAllModadlidadPE()//[FromQuery] Params paisParams
        {
            var modalidadpe = await _imodalidadpe.GetAllAsync();//(paisParams.PageIndex, paisParams.PageSize,paisParams.Search);
            //return new Pager<ModalidadPe>(modalidadpe.registros, pais.totalRegistros,paisParams.PageIndex, paisParams.PageSize, paisParams.Search);
             if (modalidadpe == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(modalidadpe);
        }


        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<ModalidadPe>> GetUOCbyId(int id)
        {
            var modalidadPe = await _imodalidadpe.GetByIdAsync(id);
            if (modalidadPe == null)
                return NotFound(new ApiResponse(404));
            return Ok(modalidadPe);
        }

        [Route("GetMPEActivas")]
        [HttpGet]
        public async Task<ActionResult<ModalidadPe>> GetAllUOCActivasAsync()
        {
            var modalidadPe = await _imodalidadpe.GetAllMPEActivasAsync();
            if (modalidadPe == null)
                return NotFound(new ApiResponse(404));
            return Ok(modalidadPe);
        }

        [Route("GetByCod/{cod}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModalidadPe>>> GetMPEbyCod(string cod)
        {
            var modalidadPe = await _imodalidadpe.GetByCodmpeAsync(cod);
            if (modalidadPe == null)
                return NotFound(new ApiResponse(404));
            return Ok(modalidadPe);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<ModalidadPe>> SaveMPE([FromBody] ModalidadPEDto mpedto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModalidadPEDto, ModalidadPe>();
            });
            var _mapper = new Mapper(config);
            var _mpe = _mapper.Map<ModalidadPe>(mpedto);
            _imodalidadpe.Add(_mpe);
            await _imodalidadpe.SaveAsync();
            if (mpedto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            mpedto.IdModalidadPe = _mpe.IdModalidadPe;
            return CreatedAtAction(nameof(SaveMPE), new { IdModadlidadPe = mpedto.IdModalidadPe });

        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<ModalidadPEDto>> Put(int id, [FromBody] ModalidadPEDto mpedto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ModalidadPEDto, ModalidadPe>();
            });
            var _mapper = new Mapper(config);



            if (mpedto == null)
                return NotFound(new ApiResponse(404, "La modalidad plan estudio solicitada no existe."));

            var _mpe = await _imodalidadpe.GetByIdAsync(id);
            if (_mpe == null)
                return NotFound(new ApiResponse(404, "La modalidad plan estudio solicitada no existe."));

            var _mpedto = _mapper.Map<ModalidadPe>(mpedto);
            _imodalidadpe.Update(_mpedto);
            await _imodalidadpe.SaveAsync();
            return mpedto;
        }
        [Route("Delete/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _imodalidadpe.GetByIdAsync(id);
            if (producto == null)
                return NotFound(new ApiResponse(404, "La modalidad plan estudio que solicita no existe."));

            _imodalidadpe.Remove(producto);
            await _imodalidadpe.SaveAsync();

            return NoContent();
        }
    }
}
