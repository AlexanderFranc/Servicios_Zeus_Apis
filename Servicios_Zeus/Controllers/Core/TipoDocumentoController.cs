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
    [Route("api/tipo-documento")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class TipoDocumentoCOntroller : ControllerBase
    {
        private readonly ITipoDocumentoRepository _itipoDoc;
        private readonly IMapper _mapper;
        public TipoDocumentoCOntroller(ITipoDocumentoRepository tipoDocrepo, IMapper mapper)
        {
            _itipoDoc = tipoDocrepo;
            _mapper = mapper;
        }

        [Route("listar")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDocumento>>> GetAllTipoDocumento()
        {
            var tipoDoc = await _itipoDoc.GetAllAsync();
            if (tipoDoc == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(tipoDoc);
        }

        [Route("ver/{id}")]
        [HttpGet]
        public async Task<ActionResult<TipoDocumento>> GetTipoDocumentoById(int id)
        {
            var tipoDoc = await _itipoDoc.GetByIdAsync(id);
            if (tipoDoc == null)
                return NotFound(new ApiResponse(404));
            return Ok(tipoDoc);
        }

        [Route("crear")]
        [HttpPost]
        public async Task<ActionResult<TipoDocumento>> SaveTipoDocumento([FromBody] TipoDocumentoDto tipodocdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoDocumentoDto, TipoDocumento>();
            });
            var _mapper = new Mapper(config);
            var _tipodoc = _mapper.Map<TipoDocumento>(tipodocdto);
            _itipoDoc.Add(_tipodoc);
            await _itipoDoc.SaveAsync();
            if (tipodocdto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            tipodocdto.IdTipoDocumento = _tipodoc.IdTipoDocumento;
            return CreatedAtAction(nameof(SaveTipoDocumento), new { IdTipoDocumento = tipodocdto.IdTipoDocumento });
        }

        [Route("editar/{id}")]
        [HttpPut]
        public async Task<ActionResult<TipoDocumentoDto>> Put(int id, [FromBody] TipoDocumentoDto tipodocdto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoDocumentoDto, TipoDocumento>();
            });
            var _mapper = new Mapper(config);

            if (tipodocdto == null)
                return NotFound(new ApiResponse(404, "El Tipo Documento solicitado no existe."));

            var _tipodoc = await _itipoDoc.GetByIdAsync(id);
            if (_tipodoc == null)
                return NotFound(new ApiResponse(404, "El Tipo Documento solicitado no existe."));

            var _provinciadto = _mapper.Map<TipoDocumento>(tipodocdto);
            _itipoDoc.Update(_provinciadto);
            await _itipoDoc.SaveAsync();
            return tipodocdto;
        }
    }
}
