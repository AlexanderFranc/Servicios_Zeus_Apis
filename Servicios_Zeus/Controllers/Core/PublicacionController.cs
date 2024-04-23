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
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class PublicacionController : ControllerBase
    {
        private readonly IPublicacionRepository _ipublic;
        private readonly IMapper _mapper;

        public PublicacionController(IPublicacionRepository publirepo, IMapper mapper)
        {
            _ipublic = publirepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publicacion>>> GetAllPublicacion()
        {
            var publi = await _ipublic.GetAllAsync();
            if (publi == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(publi);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Publicacion>> GetPublicacionbyId(int id)
        {
            var publi = await _ipublic.GetByIdAsync(id);
            if (publi == null)
                return NotFound(new ApiResponse(404));
            return Ok(publi);
        }

        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<Publicacion>> SavePublicacion([FromBody] PublicacionDto publidto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PublicacionDto, Publicacion>();
            });
            var _mapper = new Mapper(config);
            var _publi = _mapper.Map<Publicacion>(publidto);
            _ipublic.Add(_publi);
            await _ipublic.SaveAsync();
            if (publidto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            publidto.IdPublicacion = _publi.IdPublicacion;
            return CreatedAtAction(nameof(SavePublicacion), new { IdPublicacion = publidto.IdPublicacion });
        }

        [Route("Update/{id}")]
        [HttpPut]
        public async Task<ActionResult<PublicacionDto>> Put(int id, [FromBody] PublicacionDto publidto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PublicacionDto, Publicacion>();
            });
            var _mapper = new Mapper(config);

            if (publidto == null)
                return NotFound(new ApiResponse(404, "La Plublicacion solicitado no existe."));

            var _publi = await _ipublic.GetByIdAsync(id);
            if (_publi == null)
                return NotFound(new ApiResponse(404, "La Plublicacion solicitado no existe."));

            var _publidto = _mapper.Map<Publicacion>(publidto);
            _ipublic.Update(_publidto);
            await _ipublic.SaveAsync();
            return publidto;
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var _publi = await _ipublic.GetByIdAsync(id);
            if (_publi == null)
                return NotFound(new ApiResponse(404, "La Plublicacion que solicita no existe."));

            _ipublic.Remove(_publi);
            await _ipublic.SaveAsync();

            return NoContent();
        }


    }
}
