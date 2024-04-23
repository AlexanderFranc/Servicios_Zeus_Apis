using AutoMapper;
using Core.Dtos.Core;
using Core.Interfaces.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Core
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class DatosGeneralesSilaboController : ControllerBase
    {
        private readonly IDatosGeneralesSilaboRepository _irepository;
        public DatosGeneralesSilaboController(IDatosGeneralesSilaboRepository repository)
        {
            _irepository = repository;
        }

            [Route("GetById/{idplan}/{idmateria}")]
            [HttpGet]
            public async Task<ActionResult<DatosGeneralesSilaboDto>> getDatosGeneralesSilabo(int idplan, int idmateria)
            {
                var carrera = await _irepository.getDatosGeneralesSilabo(idplan, idmateria);
                if (carrera == null)
                    return NotFound(new ApiResponse(404));
                return Ok(carrera);
            }

        
    }
}
