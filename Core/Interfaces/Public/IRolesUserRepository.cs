using Servicios_Zeus.Dtos;

namespace Core.Interfaces.Public
{
    public interface IRolesUserRepository
    {
        Task<ICollection<UsuarioPerfilDto>> GetRolesUsuario(string nombreperfil, string nombreaplicacion);

    }
}
