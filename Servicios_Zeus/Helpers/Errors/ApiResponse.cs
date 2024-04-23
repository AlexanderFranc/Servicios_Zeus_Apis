namespace Servicios_Zeus.Helpers.Errors
{
    public class ApiResponse
    {
        public int Statuscode { get; set; }
        public string Message { get; set; }

        public ApiResponse(int statuscode, string message = null)
        {
            this.Statuscode = statuscode;
            this.Message = message ?? GetDefaultMessage(statuscode);
        }

        private string GetDefaultMessage(int statuscode)
        {
            return statuscode switch
            {
                400 => "Ha realizado una petición incorrecta.",
                401 => "Usuario no autorizado.",
                404 => "El recurso al cual está intentado acceder no existe.",
                405 => "El método HTTP no está permitido en el servidor.",
                500 => "Ha ocurrido un error en el servidor por favor comuníquese con el administrador.",
                _ => "Mensaje de error predeterminado para otros códigos de estado."


            };
        }
    }
}
