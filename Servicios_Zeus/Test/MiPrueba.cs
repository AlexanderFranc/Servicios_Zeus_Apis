using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Servicios_Zeus.Test
{
    public class PruebasIntegracion : IClassFixture<WebApplicationFactory<Program>>
    {
        //private readonly WebApplicationFactory<Program> _factory;

        //public PruebasIntegracion(WebApplicationFactory<Program> factory)
        //{
        //    _factory = factory;
        //}

        //[Fact]
        //public async Task DebeRetornarOK()
        //{
        //    // Crea un cliente HTTP para hacer solicitudes a la aplicación
        //    var client = _factory.CreateClient();

        //    // Realiza una solicitud GET al endpoint deseado
        //    var response = await client.GetAsync("/api/controlador/endpoint");

        //    // Asegúrate de que la respuesta sea exitosa (código 200)
        //    response.EnsureSuccessStatusCode();

        //    // Puedes agregar más aserciones aquí para verificar el contenido de la respuesta si es necesario
        //}
    }
}
