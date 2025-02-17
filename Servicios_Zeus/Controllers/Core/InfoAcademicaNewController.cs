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
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class InfoAcademicaNewController : ControllerBase
    {
        private readonly IInfoAcademicaNewRepository _iinfoAcad;
        private readonly IMapper _mapper;
        public InfoAcademicaNewController(IInfoAcademicaNewRepository infoacadrepo, IMapper mapper)
        {
            _iinfoAcad = infoacadrepo;
            _mapper = mapper;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfoAcademicaNew>>> GetAllInfoAcademica()
        {
            var infoAcad = await _iinfoAcad.GetAllAsync();
            if (infoAcad == null)
                return NotFound(new ApiResponse(404, "La lista no contiene ningún elemento."));
            return Ok(infoAcad);
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<InfoAcademicaNew>> GetInfoAcademicabyId(int id)
        {
            var infoAcad = await _iinfoAcad.GetByIdAsync(id);
            if (infoAcad == null)
                return NotFound(new ApiResponse(404));
            return Ok(infoAcad);
        }

        [Route("findByIdEmpl/{id}")]
        [HttpGet]
        public async Task<ActionResult<InfoAcademicaNew>> GetfindByDni(int id)
        {
            var infoAcad = await _iinfoAcad.GetByIdEmpleado(id);
            if (infoAcad == null)
                return NotFound(new ApiResponse(404));
            return Ok(infoAcad);
        }

        [Route("Save1")]
        [HttpPost]
        public bool SaveInfoAcademica([FromBody] InfoAcademicaNewDto infoacademdto)
        {
            return _iinfoAcad.SaveInfoAcademico(infoacademdto);
        }

        [Route("eliminar/{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var infoAcad = await _iinfoAcad.GetByIdAsync(id);
            if (infoAcad == null)
                return NotFound(new ApiResponse(404, "La Info. Academica que solicita no existe."));

            _iinfoAcad.Remove(infoAcad);
            await _iinfoAcad.SaveAsync();

            return NoContent();
        }
        [Route("Save")]
        [HttpPost]
        public async Task<ActionResult<InfoAcademicaNew>> save([FromBody] InfoAcademicaNewDto infoDto)
        {

        var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InfoAcademicaNewDto, InfoAcademicaNew>()
                 .ForMember(dest => dest.IdInfoAcademica, opt => opt.Ignore())
                 .ForMember(dest => dest.IdEmpNavigation, opt => opt.Ignore())
                 .ForMember(dest => dest.IdNivelAcademicoNavigation, opt => opt.Ignore())
                 .ForMember(dest => dest.IdUnidadEducativaNavigation, opt => opt.Ignore());
              
            });
            infoDto.FC = DateTime.Now;
            infoDto.UA = "";
            infoDto.FA = null;
            infoDto.FAprueba = null;
            var _mapper = new Mapper(config);
            var _data = _mapper.Map<InfoAcademicaNew>(infoDto);
            _iinfoAcad.Add(_data);
            await _iinfoAcad.SaveAsync();
            if (infoDto == null)
            {
                return BadRequest(new ApiResponse(400));
            }
            infoDto.IdInfoAcademica = _data.IdInfoAcademica;
            return CreatedAtAction(nameof(save), new
            {
                IdInfoAcademica = infoDto.IdInfoAcademica,
            });
        }
    }
}
