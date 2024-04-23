using Core.Entidades.Core;
using Infraestructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios_Zeus.Controllers
{
    /// <summary>
    /// Servicio construido a traves de dataset
    /// </summary>
    [Route("api/asesor")]
    [ApiController]
    public class AsesorController : ControllerBase
    {
        AsesorRepository serviceAsesor = new AsesorRepository();
        [Route("GetAll")]
        [HttpGet]
        public List<Asesor> getAsesor()
        {
            return serviceAsesor.getAsesor();
        }
    }
}
