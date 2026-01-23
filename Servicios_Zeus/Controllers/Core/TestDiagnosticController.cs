using Microsoft.AspNetCore.Mvc;

namespace Servicios_Zeus.Controllers.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDiagnosticController : ControllerBase
    {
        private readonly IConfiguration _config;

        public TestDiagnosticController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("EnvironmentCheck")]
        public IActionResult GetEnvironmentDetails()
        {
            var environment = _config["ASPNETCORE_ENVIRONMENT"];
            var sftpServer = _config["SFtpSettings:Server"];
            var connectionString = _config.GetConnectionString("ZEUS");
            var currentDirectory = Directory.GetCurrentDirectory();

            return Ok(new
            {
                EnvironmentName = environment,
                SFTP_Server = sftpServer,
                ConnectionString = connectionString,
                CurrentDirectory = currentDirectory
            });
        }
    }
}
