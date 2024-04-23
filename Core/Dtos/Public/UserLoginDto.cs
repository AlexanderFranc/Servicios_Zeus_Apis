

using System.Text.Json.Serialization;
using Core.Dtos.Public;
using Servicios_Zeus.Dtos;

namespace Core.Dtos.Public
{
    public class UserLoginDto
    {
        public string NombreUsuario { get; set; }

        public string? DniUsuario { get; set; }

        public string? Email { get; set; }

        public bool? ActivoUsuario { get; set; }

        public string? FotoUsuario { get; set; }

        public string? NombresUsuario { get; set; }

        public string? ApellidosUsuario { get; set; }

        public bool EstaAutenticado { get; set; }
        public string? Mensaje { get; set; }
        public string? NombreAplicacion { get; set; }
        public virtual ICollection<UsuarioPerfilDto> usuarioperfil { get; set; }
        public virtual JWT Seguridad { get; set; }

        //[JsonIgnore]
        /*Refresh token*/

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }


    }
}
