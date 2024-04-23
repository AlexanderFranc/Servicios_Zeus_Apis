using AutoMapper;
using Core.Dtos.Ftp;
using Core.Interfaces.Core;
using Core.Interfaces.Ftp;
using Infraestructure.Repository.Ftp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios_Zeus.Helpers.Errors;

namespace Servicios_Zeus.Controllers.Ftp
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class FtpController : ControllerBase
    {

        private readonly IFtpRepository _irepository;
        public FtpController(IFtpRepository ftprepo)
        {
            _irepository = ftprepo;

        }
        [HttpPost("uploadBytes")]
        public IActionResult SubirArchivo([FromBody] SubirArchivoRequestDto request)
        {
            try
            {
                byte[] archivoBytes = Convert.FromBase64String(request.ArchivoBase64);
                string pathRemoto = request.PathRemoto;
                string nombreArchivo = request.NombreArchivo;

                _irepository.SubirArchivoFtp(archivoBytes, pathRemoto, nombreArchivo);

                return Ok("Archivo subido correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al cargar el archivo al servidor FTP: {ex.Message}");
            }
        }
        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        public IActionResult SubirArchivoFtp([FromForm] IFormFile file, [FromForm] string remoteFilePath)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No se proporcionó un archivo válido para cargar.");
            }

            try
            {
                _irepository.subirArchivoFtp(file,remoteFilePath);

                return Ok("Archivo subido exitosamente al servidor FTP.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error al subir el archivo al servidor FTP: " + ex.Message);
            }
        }
        [HttpGet("download")]
        public async  Task<IActionResult> DescargarArchivo(string request)
        {
            if (!string.IsNullOrEmpty(request))
            {
                    string nombreArchivo = Path.GetFileName(request);
                    byte[] archivoBytes = await  _irepository.descargarArchivoFtp(request);
                    if (archivoBytes != null && archivoBytes.Length > 0)
                    {
                        return File(archivoBytes, "application/octet-stream", nombreArchivo);
                    }
            }

            return BadRequest("Error al descargar el archivo desde el servidor FTP.");
        }
        [HttpDelete("delete")]
        public IActionResult EliminarArchivo(string request)
        {
            if (!string.IsNullOrEmpty(request))
            {
   
                string nombreArchivo = Path.GetFileName(request);
                _irepository.eliminarArchivo(request);
                return Ok("Archivo "+nombreArchivo+" eliminado correctamente");
            }

            return BadRequest("Error al eliminar el archivo desde el servidor FTP.");
        }
    }
}
